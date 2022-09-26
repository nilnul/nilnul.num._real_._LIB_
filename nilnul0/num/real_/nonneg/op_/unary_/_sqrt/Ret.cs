using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num.real_.nonneg.op_.unary_._sqrt
{
	/// <summary>
	/// 
	/// </summary>
	public class Ret :
		nilnul.obj.Box<nilnul.num.real_.NonnegI>
		,
		nilnul.num.RealI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="targetOfSqrt"></param>
		public Ret(nilnul.num.real_.NonnegI targetOfSqrt) : base(targetOfSqrt)
		{
			var lowerSrc = _SqrtX.Real_assumeNonneg(
					targetOfSqrt.current.lower.mark
				);

			var upperSrc = _SqrtX.Real_assumeNonneg(
					targetOfSqrt.current.upper.mark
				);

			_bound = new nilnul.num.quotient.bound_.Closed(

					lowerSrc.current.lower.mark


				,

					upperSrc.current.upper.mark


			);


		}

		public Ret(PositiveI arg) : this(new real_.Nonneg(arg))
		{
		}

		private num.quotient.bound_.Closed _bound;
		public num.quotient.bound_.Closed current => _bound;

		public void squeeze(num.quotient_.Positive1 diameter)
		{

			_bound = num.quotient.bound_.Closed.Create_byMergeBorder(
				nilnul.num.real.op_.unary_.injective_.upward._inverse._ret_._clamp._NarrowSrcX.DomainNarrowDown(
					boxed
					,

					num.real.op_.unary_.Square.Singleton, num.quotient.Bound.CreateClose(_bound.lower.mark, _bound.upper.mark)
					,
					diameter
				)
			);




		}


	}
}

