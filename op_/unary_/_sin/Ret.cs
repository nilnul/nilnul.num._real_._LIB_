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

	[Obsolete("too slow, use " + nameof(Ret_ofAcuteMaybeIrration_byClampArg), true)]

	public class Ret_ofMaybeIrration
		:
		nilnul.num.real._calc.Arg
		,
		A

	{
		public Ret_ofMaybeIrration(A arg):base(arg)
		{

			var lowerOped = op_.unary_._SinX.RetRealI(arg.current.lower.mark);
			var upperOped = op_.unary_._SinX.RetRealI(arg.current.upper.mark);


			//var lowerBorder = new nilnul.num.quotient.Border2(
			//	true
			//	//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
			//	,
			//	lowerOped.current.lower.mark);


			//var upperBorder = new nilnul.num.quotient.Border2(
			//	true
			//	//arg.bound.upper.openFalseCloseTrue
			//	//&& upperOped.bound.upper.openFalseCloseTrue
			//	,
			//	upperOped.current.upper.mark
			//);

			_bound = new nilnul.num.quotient.bound_.Closed(
				lowerOped.current.lower.mark,
				upperOped.current.upper.mark
			);
		}



		private nilnul.num.quotient.bound_.Closed _bound;
		public nilnul.num.quotient.bound_.Closed current
		{
			get
			{
				
				return _bound;
			}
		}


		public void squeeze(nilnul.num.quotient_.Positive1 diameter)
		{


			var diameter_oneThird = new nilnul.num.quotient_.Positive1( diameter / 3);


			while (

				_bound.diameterGt(diameter)


				)
			{

				arg.Clamp1K(


				);

				var lowerOped = real.op_.unary_._SinX.RetRealI(arg.current.lower.mark);
				var upperOped = real.op_.unary_._SinX.RetRealI(arg.current.upper.mark);


				lowerOped.squeeze(diameter_oneThird);
				upperOped.squeeze(diameter_oneThird);


				//var lowerBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
				//	,
				//	lowerOped.current.lower.mark);


				//var upperBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.upper.openFalseCloseTrue
				//	//&& upperOped.bound.upper.openFalseCloseTrue
				//	,
				//	upperOped.current.upper.mark
				//);


				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(_bound

					,new nilnul.num.quotient.bound_.Closed(lowerOped.current.lower.mark, upperOped.current.upper.mark)
				);



			}


			//throw new NotImplementedException();
		}
	}
}
