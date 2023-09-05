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



	/// <summary>
	/// arg is in (-t/4,t/4)
	/// </summary>
	public class Ret_ofAcute_byClampArg
		:
		nilnul.num.real._calc.Arg
		,
		A

	{



		public Ret_ofAcute_byClampArg(A arg) : base(arg)
		{
			/// note: cos is not necessarily increasing function. in fact it's a decrese function.
			///
			if (arg.current.lower.mark >= 0)
			{
				var srclowerOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.lower.mark);


				var argUpperOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.upper.mark);


				//var upperBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
				//	,
				//					nilnul.num.quotient.op_.binary_._MaxX.Max(

				//	srclowerOped.current.upper.mark
				//	,
				//	argUpperOped.current.upper.mark
				//	)
				//);


				//var lowerBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.upper.openFalseCloseTrue
				//	//&& upperOped.bound.upper.openFalseCloseTrue
				//	,
				//	nilnul.num.quotient.op_.binary_._MinX.Min(

				//	argUpperOped.current.lower.mark
				//	,
				//	srclowerOped.current.lower.mark
				//	)
				//);
				_bound = new nilnul.num.quotient.bound_.Closed(
nilnul.num.quotient.op_.binary_._MinX.Min(

					argUpperOped.current.lower.mark
					,
					srclowerOped.current.lower.mark
					)
					,
nilnul.num.quotient.op_.binary_._MaxX.Max(

					srclowerOped.current.upper.mark
					,
					argUpperOped.current.upper.mark
					)
);
				return;
			}
			else
			if (arg.current.upper.mark <= 0)
			{
				var srclowerOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.lower.mark);


				var argUpperOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.upper.mark);


				//var upperBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue
				//	,
				//					nilnul.num.quotient.op_.binary_._MaxX.Max(

				//	argUpperOped.current.upper.mark
				//	,
				//	srclowerOped.current.upper.mark
				//	)
				//);


				//var lowerBorder = new nilnul.num.quotient.Border2(
				//	true
				//	//arg.bound.upper.openFalseCloseTrue
				//	//&& upperOped.bound.upper.openFalseCloseTrue
				//	,
				//	nilnul.num.quotient.op_.binary_._MinX.Min(

				//	srclowerOped.current.lower.mark
				//	,
				//	argUpperOped.current.lower.mark
				//	)
				//);
				_bound = new nilnul.num.quotient.bound_.Closed(
					nilnul.num.quotient.op_.binary_._MinX.Min(

					srclowerOped.current.lower.mark
					,
					argUpperOped.current.lower.mark
					)

					,
					nilnul.num.quotient.op_.binary_._MaxX.Max(

					argUpperOped.current.upper.mark
					,
					srclowerOped.current.upper.mark
					));
				return;

			}
			else
			{//convex

				//var srclowerOped = op_.unary_._CosX.RealI(arg.bound.lower.mark);


				//var argUpperOped = op_.unary_._CosX.RealI(arg.bound.upper.mark);

				var min = nilnul.num.quotient.op_.binary_._MaxX.Max(
					arg.current.lower.mark.Abs(), arg.current.upper.mark.Abs()
				);

				var minOped = op_.unary_._Cos_byClampArgX.RealI(min);

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
				//	//nilnul.num.quotient.op_.binary_._MinX.Min(

				//	minOped.current.lower.mark
				//	//,
				//	//1)
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

			var diameter_oneThird = diameter / 3u;

			arg.squeeze(diameter_oneThird);

			nilnul.num.Quotient1 lowerBorder, upperBorder;

			if (arg.current.lower.mark >= 0)
			{

				var argLowerOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.lower.mark);

				var argUpperOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.upper.mark);

				argLowerOped.Clamp(diameter_oneThird);


				argUpperOped.Clamp(diameter_oneThird);


				upperBorder = 
				   nilnul.num.quotient.op_.binary_._MaxX.Max(
					   argUpperOped.current.upper.mark,
				   argLowerOped.current.upper.mark
				   )
			   ;


				lowerBorder = 
				   nilnul.num.quotient.op_.binary_._MinX.Min(

				   argUpperOped.current.lower.mark
				   ,
				   argLowerOped.current.lower.mark
				   )
			  ;



				//var argLowerOped = real.op_.unary_._CosX.RealI(arg.bound.lower.mark);
				//var argUpperOped = real.op_.unary_._CosX.RealI(arg.bound.upper.mark);



				/// note: cos is not necessarily increasing function. in fact it's a decrese function.
				///

				//_bound = new nilnul.num.quotient.Bound(lowerBorder, upperBorder);
			}
			else
				if (arg.current.upper.mark <= 0)
			{
				var argLowerOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.lower.mark);


				var argUpperOped = op_.unary_._Cos_byClampArgX.RealI(arg.current.upper.mark);

				argLowerOped.Clamp(diameter_oneThird);
				argUpperOped.Clamp(diameter_oneThird);

				upperBorder = 
						  nilnul.num.quotient.op_.binary_._MaxX.Max(

				   argUpperOped.current.upper.mark
				   , argLowerOped.current.upper.mark
				   )
			  ;


				lowerBorder = 
						  nilnul.num.quotient.op_.binary_._MinX.Min(

				   argLowerOped.current.lower.mark
				   , argUpperOped.current.lower.mark
				   )
			   ;
				//_bound = new nilnul.num.quotient.Bound(lowerBorder, upperBorder);

			}
			else

			{//convex

				//var srclowerOped = op_.unary_._CosX.RealI(arg.bound.lower.mark);


				//var argUpperOped = op_.unary_._CosX.RealI(arg.bound.upper.mark);

				var min = nilnul.num.quotient.op_.binary_._MaxX.Max(
					arg.current.lower.mark.Abs(), arg.current.upper.mark.Abs()
				);


				var minOped = op_.unary_._Cos_byClampArgX.RealI(min);
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
				new nilnul.num.quotient.bound_.Closed(lowerBorder,upperBorder)
			);

		}
		//throw new NotImplementedException();
	}

}
