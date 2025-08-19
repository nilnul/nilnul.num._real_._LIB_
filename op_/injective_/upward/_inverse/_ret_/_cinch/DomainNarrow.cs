using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.num.real.op_;
using nilnul.num.quotient.co;
using nilnul.num.quotient.co.diameter;
using nilnul.num.quotient.op;
using nilnul.num.real.op;



namespace nilnul.num.real.op_.injective_.upward._inverse._ret_._cinch
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
		/// <param name="opedVal_computedUsingOpBeforeInversed">
		/// src of this will be narrowed; it's known in boundOfSrc;
		/// this value will not change after this method
		/// </param>
		/// <param name="intendedAccuracy_ofSrc">
		///  assume that the src is in this;
		///		the found scope must be short enough (lt accuracy)
		/// </param>
		/// <returns></returns>
		static public (Q4 begin, Q4 end) DomainNarrowDown(
				nilnul.num.RealI_onQuotient opedVal_computedUsingOpBeforeInversed
			,
				nilnul.num.real.OpI1 op_beforeInversed
				,
				(num.quotient_.DenomNonnil begin, num.quotient_.DenomNonnil end) boundOfSrc_known
				,
				num.quotient_.denomNonnil_.Positive intendedAccuracy_ofSrc
			)
		{

			while (
				boundOfSrc_known.DiameterGt(intendedAccuracy_ofSrc)
			)
			{
				var mid = boundOfSrc_known.Mid();

				var one4th = (boundOfSrc_known.begin + mid) / 2;

				var three4th = (mid + boundOfSrc_known.end) / 2;

				var srcPoints = new[] { boundOfSrc_known.begin, one4th, mid, three4th, boundOfSrc_known.end };



				var lowerOped = op_beforeInversed.Op(boundOfSrc_known.begin);

				var one4thOped = op_beforeInversed.Op(one4th);
				var midOped = op_beforeInversed.Op(mid);
				var three4thOped = op_beforeInversed.Op(three4th);
				var upperOped = op_beforeInversed.Op(boundOfSrc_known.end);

				#region make them away (not intersect, not adjacent)


				while (
					lowerOped.current.end >= one4thOped.current.begin
					)
				{
					lowerOped.CinchHalf();
					one4thOped.CinchHalf();
				}

				while (
					one4thOped.current.end >= midOped.current.begin
					)
				{
					one4thOped.CinchHalf();
					midOped.CinchHalf();
				}

				while (
					midOped.current.end >= three4thOped.current.begin
					)
				{
					midOped.CinchHalf();
					three4thOped.CinchHalf();
				}

				while (
					three4thOped.current.end >= upperOped.current.begin
					)
				{
					three4thOped.CinchHalf();
					upperOped.CinchHalf();
				}
				#endregion

				var tgtBoundOfEveryPoint = new[] {
					lowerOped.current
					,
					one4thOped.current
					,
					midOped.current
					,
					three4thOped.current
					,
					upperOped.current
				}.ToList();

				#region at most 1 being disjoint with 

				#endregion
				while (
					tgtBoundOfEveryPoint.Count(
						b => nilnul.num.quotient.clasp.re_._JointX._Re_01clasp(
							b,
							opedVal_computedUsingOpBeforeInversed.current
						)
					) > 1
				)
				{
					opedVal_computedUsingOpBeforeInversed.CinchHalf();
				} // now tgtRange is joint with at most one candidate ranges;


				var infimumGreaterRange = tgtBoundOfEveryPoint.FirstOrDefault(
					upperRange => upperRange.begin >= opedVal_computedUsingOpBeforeInversed.current.end
				);

				quotient_.DenomNonnil newUpper_ofSrc2Find;

				//if (infimumGreaterRange==default) throws null exception as "==" the overloaded is called.
				//if (infimumGreaterRange is null)		// using null still throws exception as "==" is still called
				if (infimumGreaterRange.begin is null)
				{
					newUpper_ofSrc2Find = boundOfSrc_known.end;

				}
				else
				{
					newUpper_ofSrc2Find = (
						srcPoints[tgtBoundOfEveryPoint.FindIndex(x => x == infimumGreaterRange)]
					);
				}


				var smallerRange = tgtBoundOfEveryPoint.AsEnumerable().Reverse().FirstOrDefault(b => b.end <= opedVal_computedUsingOpBeforeInversed.current.begin);//?? lowerExped.bound;

				quotient_.DenomNonnil newLower_ofSrc2Find;

				if (smallerRange.begin is null)
				{
					newLower_ofSrc2Find = boundOfSrc_known.begin;

				}
				else
				{
					newLower_ofSrc2Find = (srcPoints[tgtBoundOfEveryPoint.FindIndex(x => x == smallerRange)]);

				}



				boundOfSrc_known = (newLower_ofSrc2Find, newUpper_ofSrc2Find);



			}

			return boundOfSrc_known;


		}

	
	}
}
