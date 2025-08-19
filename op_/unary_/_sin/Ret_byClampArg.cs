using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.Quotient1;
using Q1 = nilnul.num.Quotient1;

using R = nilnul.num.RealI;

using R1 = nilnul.num.RealI;

using N = nilnul.Num1;
using nilnul.num.real;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using A = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_._sin
{

	/// <summary>
	/// arg in (-t/4, t/4)
	/// </summary>
	public class Ret_ofAcuteMaybeIrration_byClampArg
		:
		nilnul.num.real._calc.Arg
		,
		A

	{
		public Ret_ofAcuteMaybeIrration_byClampArg(A arg) : base(arg)
		{

			var lowerOped = op_.unary_._Sin_byClampArgX.RetRealI(arg.current.lower.mark);
			var upperOped = op_.unary_._Sin_byClampArgX.RetRealI(arg.current.upper.mark);


			//var lowerBorder = new nilnul.num.quotient.Border2(
			//	true
			//	//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
			//	,
			//	nilnul.num.quotient.op_.binary_._MinX.Min(
			//		lowerOped.current.lower.mark
			//		,
			//		upperOped.current.lower.mark
			//	)
			//);


			//var upperBorder = new nilnul.num.quotient.Border2(
			//	true
			//	//arg.bound.upper.openFalseCloseTrue
			//	//&& upperOped.bound.upper.openFalseCloseTrue
			//	,
			//	nilnul.num.quotient.op_.binary_._MaxX.Max(
			//		upperOped.current.upper.mark
			//		,
			//		lowerOped.current.upper.mark
			//	)
			//);

			_boundOfLimit = new nilnul.num.quotient.bound_.Closed(nilnul.num.quotient.op_.binary_._MinX.Min(
					lowerOped.current.lower.mark
					,
					upperOped.current.lower.mark
				), nilnul.num.quotient.op_.binary_._MaxX.Max(
					upperOped.current.upper.mark
					,
					lowerOped.current.upper.mark
				));
		}



		private nilnul.num.quotient.bound_.Closed _boundOfLimit;
		public nilnul.num.quotient.bound_.Closed current
		{
			get
			{

				return _boundOfLimit;
			}
		}


		public void squeeze(nilnul.num.quotient_.Positive1 diameter)
		{


			var diameter_oneThird = new nilnul.num.quotient_.Positive1(diameter / 3);
			//var diameter_half =// new nilnul.num.quotient_.Positive1(
			//	diameter / 2u
			//	//)
			//	;

			arg.squeeze(diameter_oneThird);

			var lowerOped = real.op_.unary_._Sin_byClampArgX.RetRealI(arg.current.lower.mark);
			var upperOped = real.op_.unary_._Sin_byClampArgX.RetRealI(arg.current.upper.mark);


			lowerOped.squeeze(diameter_oneThird);
			upperOped.squeeze(diameter_oneThird);

			var lowerBorder = new nilnul.num.quotient.Border2(
				true
				//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
				,
				nilnul.num.quotient.op_.binary_._MinX.Min(

				lowerOped.current.lower.mark
				,
				upperOped.current.lower.mark
				));


			var upperBorder = new nilnul.num.quotient.Border2(
				true
				//arg.bound.upper.openFalseCloseTrue
				//&& upperOped.bound.upper.openFalseCloseTrue
				,
				nilnul.num.quotient.op_.binary_._MaxX.Max(

				upperOped.current.upper.mark
				,
				lowerOped.current.lower.mark
				)
			);


			_boundOfLimit = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(_boundOfLimit

				, new nilnul.num.quotient.bound_.Closed(nilnul.num.quotient.op_.binary_._MinX.Min(

				lowerOped.current.lower.mark
				,
				upperOped.current.lower.mark
				), nilnul.num.quotient.op_.binary_._MaxX.Max(

				upperOped.current.upper.mark
				,
				lowerOped.current.lower.mark
				))
			);




			//throw new NotImplementedException();
		}
	}
}
