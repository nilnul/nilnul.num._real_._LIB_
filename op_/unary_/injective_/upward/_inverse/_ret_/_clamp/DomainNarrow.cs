using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.num.real.op_;

namespace nilnul.num.real.op_.unary_.injective_.upward._inverse._ret_._clamp
{
	/// <summary>
	/// 
	/// </summary>
	static public class _NarrowSrcX
	{
		/// <summary>
		/// find a src bound, which contains the src of the target.
		/// </summary>
		/// <param name="boundOfSrc_known">the domain</param>
		/// <param name="op_beforeInversed">function:domain --->>  target; must be strict increasing monotonic function</param>
		/// <param name="opedVal_computedUsingOpBeforeInversed">src of this will be narrowed; it's know in boundOfSrc
		///this value will not change after this method
		/// </param>
		/// <param name="intendedAccuracy_ofSrc">
		///		the found scope must be short enough (lt accuracy)
		/// </param>
		/// <returns></returns>
		static public num.quotient.Bound DomainNarrowDown(
				nilnul.num.RealI opedVal_computedUsingOpBeforeInversed
			,
				nilnul.num.real.op_.UnaryI op_beforeInversed
				,
				num.quotient.Bound boundOfSrc_known
				,
				num.quotient_.Positive1 intendedAccuracy_ofSrc
			)
		{

			while (
				boundOfSrc_known.notSpanLessThan(intendedAccuracy_ofSrc)
			)
			{

				var one4th = (boundOfSrc_known.lower.mark + boundOfSrc_known.midPoint) / 2;

				var three4th = (boundOfSrc_known.midPoint + boundOfSrc_known.upper.mark) / 2;

				var srcPoints = new[] { boundOfSrc_known.lower.mark, one4th, boundOfSrc_known.midPoint, three4th, boundOfSrc_known.upper.mark };


				
				var lowerOped = op_beforeInversed.Op(boundOfSrc_known.lower.mark);

				var one4thOped = op_beforeInversed.Op(one4th);
				var midOped = op_beforeInversed.Op(boundOfSrc_known.midPoint);
				var three4thOped = op_beforeInversed.Op(three4th);
				var upperOped = op_beforeInversed.Op(boundOfSrc_known.upper.mark);

				#region make them away (not intersect, not adjacent)


				while (
					lowerOped.current.upper.mark >= one4thOped.current.lower.mark
					)
				{
					lowerOped.Clamp1K();
					one4thOped.Clamp1K();
				}

				while (
					one4thOped.current.upper.mark >= midOped.current.lower.mark
					)
				{
					one4thOped.Clamp1K();
					midOped.Clamp1K();
				}

				while (
					midOped.current.upper.mark >= three4thOped.current.lower.mark
					)
				{
					midOped.Clamp1K();
					three4thOped.Clamp1K();
				}

				while (
					three4thOped.current.upper.mark >= upperOped.current.lower.mark
					)
				{
					three4thOped.Clamp1K();
					upperOped.Clamp1K();
				}
				#endregion

				var imageBoundOfEveryPoint = new[] {
					lowerOped.current
					,
					one4thOped.current
					,
					midOped.current
					,
					three4thOped.current
					,
					upperOped.current}.ToList();

				#region at most 1 being disjoint with 

				#endregion
				while (
					imageBoundOfEveryPoint.Count(
						b =>
							nilnul.num.quotient.bound.re_.Joint0Adjacent.Singleton.re(
								num.quotient.Bound.CreateClose(
								b.lower.mark
								,
								b.upper.mark
								),
								num.quotient.Bound.CreateClose(
								opedVal_computedUsingOpBeforeInversed.current.lower.mark
								,
								opedVal_computedUsingOpBeforeInversed.current.upper.mark

								)
							)
						
					) > 1
				)
				{

					opedVal_computedUsingOpBeforeInversed.Clamp1K();
				}


				var infimumGreaterRange = imageBoundOfEveryPoint.FirstOrDefault(
					upperRange => upperRange.lower.mark > opedVal_computedUsingOpBeforeInversed.current.upper.mark
				);// ?? upperExped.bound;

				num.quotient.Border2 newUpper_ofSrc2Find;

				//if (infimumGreaterRange==default) throws null exception as "==" the overloaded is called.
				//if (infimumGreaterRange is null)		// using null still throws exception as "==" is still called
				if (infimumGreaterRange is null)
				{
					newUpper_ofSrc2Find = boundOfSrc_known.upper;

				}
				else
				{
					newUpper_ofSrc2Find = num.quotient.Border2.CreateOpen(
						srcPoints[imageBoundOfEveryPoint.FindIndex(x => x == infimumGreaterRange)]
					);
				}


				var smallerRange = imageBoundOfEveryPoint.AsEnumerable().Reverse().FirstOrDefault(b => b.upper.mark < opedVal_computedUsingOpBeforeInversed.current.lower.mark);//?? lowerExped.bound;

				num.quotient.Border2 newLower_ofSrc2Find;

				if (smallerRange is null)
				{
					newLower_ofSrc2Find = boundOfSrc_known.lower;

				}
				else
				{
					newLower_ofSrc2Find =num.quotient.Border2.CreateOpen( srcPoints[imageBoundOfEveryPoint.FindIndex(x => x == smallerRange)]);

				}



				boundOfSrc_known = new num.quotient.Bound(newLower_ofSrc2Find, newUpper_ofSrc2Find);



			}

			return boundOfSrc_known;


		}

		internal static Closed DomainNarrowDown(nilnul.num.RealI opedVal_computedUsingOpBeforeInversed
			,
				nilnul.num.real.op_.UnaryI op_beforeInversed
				,
				num.quotient.bound_.Closed boundOfSrc_known
				,
				num.quotient_.Positive1 intendedAccuracy_ofSrc)
		{
			return Closed.Create_byMergeBorder(  DomainNarrowDown(
				opedVal_computedUsingOpBeforeInversed
				,op_beforeInversed
				,
				 num.quotient.Bound.CreateClose(boundOfSrc_known.lower.mark, boundOfSrc_known.upper.mark)
				 ,
				 intendedAccuracy_ofSrc
			)); ;
		}
	}
}
