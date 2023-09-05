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
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num.real.op_.unary_._cos
{



	[Obsolete("too slow, use " + nameof(Ret_ofAcute_byClampArg), true)]

	public class Of
		:
		nilnul.num.real._calc.Arg
		,
		A

	{



		public Of(A arg) : base(arg)
		{
			/// note: cos is not necessarily increasing function. in fact it's a decrese function.
			///
			if (arg.current.lower.mark >= 0)
			{
				var srclowerOped = op_.unary_._CosX.RealI(arg.current.lower.mark);


				var argUpperOped = op_.unary_._CosX.RealI(arg.current.upper.mark);


				//var upperBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
				//	,
				//	srclowerOped.current.upper.mark
				//);


				//var lowerBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.upper.openFalseCloseTrue
				//	//&& upperOped.bound.upper.openFalseCloseTrue
				//	,
				//	argUpperOped.current.lower.mark
				//);
				_bound = new nilnul.num.quotient.bound_.Closed(argUpperOped.current.lower.mark, srclowerOped.current.upper.mark
				);
				return;
			}
			if (arg.current.upper.mark <= 0)
			{
				var srclowerOped = op_.unary_._CosX.RealI(arg.current.lower.mark);


				var argUpperOped = op_.unary_._CosX.RealI(arg.current.upper.mark);


				var upperBorder = new nilnul.num.quotient.Border2(
					true
					//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
					,
					argUpperOped.current.upper.mark
				);


				var lowerBorder = new nilnul.num.quotient.Border2(
					true
					//arg.bound.upper.openFalseCloseTrue
					//&& upperOped.bound.upper.openFalseCloseTrue
					,
					srclowerOped.current.lower.mark
				);
				_bound = new nilnul.num.quotient.bound_.Closed(srclowerOped.current.lower.mark, argUpperOped.current.upper.mark);
				return;

			}

			{//convex

				//var srclowerOped = op_.unary_._CosX.RealI(arg.bound.lower.mark);


				//var argUpperOped = op_.unary_._CosX.RealI(arg.bound.upper.mark);

				var min = nilnul.num.quotient.op_.binary_._MaxX.Max(
					arg.current.lower.mark.Abs(), arg.current.upper.mark.Abs()
				);

				var minOped=op_.unary_._CosX.RealI(min);

				//var upperBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
				//	,
				//	1
				//);


				//var lowerBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.upper.openFalseCloseTrue
				//	//&& upperOped.bound.upper.openFalseCloseTrue
				//	,
				//	minOped.current.lower.mark
				//);
				_bound = new nilnul.num.quotient.bound_.Closed(minOped.current.lower.mark, 1);
				return;
			}







		}
		private num.quotient.bound_.Closed _bound;

		public num.quotient.bound_.Closed current
		{
			get
			{

				return _bound;
			}
		}

		public void squeeze(quotient_.Positive1 diameter)
		{

			var diameter_oneThird = diameter / (nilnul.num_.Positive1)3;
			while (
				current.diameterGt(diameter)
			)
			{
				arg.Clamp1K();

				//var argLowerOped = real.op_.unary_._CosX.RealI(arg.bound.lower.mark);
				//var argUpperOped = real.op_.unary_._CosX.RealI(arg.bound.upper.mark);


				nilnul.num.Quotient1 lowerBorder, upperBorder;

				/// note: cos is not necessarily increasing function. in fact it's a decrese function.
				///
				if (arg.current.lower.mark >= 0)
				{
					var argLowerOped = op_.unary_._CosX.RealI(arg.current.lower.mark);


					var argUpperOped = op_.unary_._CosX.RealI(arg.current.upper.mark);

					argLowerOped.Clamp(diameter_oneThird);
					argUpperOped.Clamp(diameter_oneThird);

					 upperBorder = 
						argLowerOped.current.upper.mark
					;


					 lowerBorder = 
						argUpperOped.current.lower.mark
					;
					//_bound = new nilnul.num.quotient.Bound(lowerBorder, upperBorder);
				}else
				if (arg.current.upper.mark <= 0)
				{
					var argLowerOped = op_.unary_._CosX.RealI(arg.current.lower.mark);


					var argUpperOped = op_.unary_._CosX.RealI(arg.current.upper.mark);

					argLowerOped.Clamp(diameter_oneThird);
					argUpperOped.Clamp(diameter_oneThird);

					 upperBorder = 
						argUpperOped.current.upper.mark
					;


					 lowerBorder =
						argLowerOped.current.lower.mark
					;
					//_bound = new nilnul.num.quotient.Bound(lowerBorder, upperBorder);

				}else

				{//convex

					//var srclowerOped = op_.unary_._CosX.RealI(arg.bound.lower.mark);


					//var argUpperOped = op_.unary_._CosX.RealI(arg.bound.upper.mark);

					var min = nilnul.num.quotient.op_.binary_._MaxX.Max(
						arg.current.lower.mark.Abs(), arg.current.upper.mark.Abs()
					);


					var minOped = op_.unary_._CosX.RealI(min);
					minOped.Clamp(diameter_oneThird);


					 upperBorder = 
						1
					;


					 lowerBorder = 
						minOped.current.lower.mark
					;
					//_bound = new nilnul.num.quotient.Bound(lowerBorder, upperBorder);
				}

#if DEBUG
				var lowerDec = nilnul.num.quotient_.radix_.Dec1.FroQuotient(lowerBorder, 10);

				var upperDec = nilnul.num.quotient_.radix_.Dec1.FroQuotient(upperBorder, 10);
				var argDec = nilnul.num.quotient_.radix_.Dec1.FroQuotient(arg.current.midPoint, 10);

				var distance = (upperBorder - lowerBorder);


#endif

				_bound =
					nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
						_bound,
					new nilnul.num.quotient.bound_.Closed(lowerBorder, upperBorder)
				);

			}
			//throw new NotImplementedException();
		}

	}
}
