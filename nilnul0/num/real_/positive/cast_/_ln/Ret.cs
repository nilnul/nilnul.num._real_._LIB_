using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using R = nilnul.num.Real;

using Ri = nilnul.num.RealI;

using N = nilnul.Num1;
using nilnul.num.real;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;
using nilnul.num.real_.positive.cast_;

namespace nilnul.num.real_.positive.cast_.sup_._ln
{



	[Obsolete("too slow see {nameof(ln_.ByReverseExp)}", true)]

	public class Ret
		:
		
		
		Ri

	{
		private nilnul.num.real_.Positive _arg;

		public nilnul.num.real_.Positive arg
		{
			get { return _arg; }
			set { _arg = value; }
		}


		public Ret(nilnul.num.real_.Positive arg)
		{

			this._arg = arg;


			var lowerRooted = _LnX.Convert(_arg.current.lower.mark);
			var upperRooted = _LnX.Convert(_arg.current.upper.mark);


			var lowerBorder = new nilnul.num.quotient.Border2(
				_arg.current.lower.openFalseCloseTrue && lowerRooted.current.lower.openFalseCloseTrue
				, lowerRooted.current.lower.mark);


			var upperBorder = new nilnul.num.quotient.Border2(
				_arg.current.upper.openFalseCloseTrue
				&& upperRooted.current.upper.openFalseCloseTrue
				,
				upperRooted.current.upper.mark
			);




			_bound = new q.bound_.Closed (lowerRooted.current.lower.mark, upperRooted.current.upper.mark);






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


			var diameter_oneThird = diameter / (nilnul.num_.Positive1)3;


			while (

				_bound.diameterGt(diameter)


				)
			{

				arg.Clamp1K(


				);

				var lowerRooted = _LnX.Convert(arg.current.lower.mark);
				var upperRooted = _LnX.Convert(arg.current.upper.mark);


				lowerRooted.Clamp(diameter_oneThird);
				upperRooted.Clamp(diameter_oneThird);


				var lowerBorder = new nilnul.num.quotient.Border2(arg.current.lower.openFalseCloseTrue && lowerRooted.current.lower.openFalseCloseTrue, lowerRooted.current.lower.mark);


				var upperBorder = new nilnul.num.quotient.Border2(
					arg.current.upper.openFalseCloseTrue
					&& upperRooted.current.upper.openFalseCloseTrue
					,
					upperRooted.current.upper.mark
				);




				_bound = new q.bound_.Closed(lowerRooted.current.lower.mark, upperRooted.current.upper.mark);



			}


			//throw new NotImplementedException();
		}
	}
}
