using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using R = nilnul.num.real.RealI_posConverge2NonEmpty;

using R1 = nilnul.num.RealI2;

using N = nilnul.num._num.bigint.be.Natural.Asserted;
using nilnul.num.real;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.op_.uni_._cos
{




	public class Of
		:
		
		
		ApproachI1

	{
		private nilnul.num._real.ApproachI1 _arg;

		public nilnul.num._real.ApproachI1 arg
		{
			get { return _arg; }
			//set { _arg = value; }
		}


		public Of(nilnul.num._real.ApproachI1 arg)
		{

			this._arg = arg;


			var lowerOped = op_.uni_.Cos.Eval(_arg.bound.lower.mark);
			var upperOped = op_.uni_.Cos.Eval(_arg.bound.upper.mark);


			var lowerBorder = new nilnul.num.quotient.Border1(
				_arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue,
				lowerOped.bound.lower.mark
			);


			var upperBorder = new nilnul.num.quotient.Border1(
				_arg.bound.upper.openFalseCloseTrue
				&& upperOped.bound.upper.openFalseCloseTrue
				,
				upperOped.bound.upper.mark
			);

			_bound = new Nonempty.En(lowerBorder, upperBorder);
		}


		private Nonempty.En _bound;
		public Nonempty.En bound
		{
			get
			{
				return _bound;
			}
		}

		public void clamp(Positive1.En diameter)
		{
			var diameter_oneThird = diameter / (nilnul._num.bigint.be.Positive.Asserted)3;
			while (
				_bound.notSpanLessThan(diameter)
			)
			{
				arg.ClampHalf();

				var lowerOped = approach.op_.uni_.Cos.Eval(arg.bound.lower.mark);
				var upperOped = approach.op_.uni_.Cos.Eval(arg.bound.upper.mark);


				lowerOped.Clamp(diameter_oneThird);
				upperOped.Clamp(diameter_oneThird);


				var lowerBorder = new nilnul.num.quotient.Border1(
					arg.bound.lower.openFalseCloseTrue && lowerOped.bound.lower.openFalseCloseTrue,
					lowerOped.bound.lower.mark
				);


				var upperBorder = new nilnul.num.quotient.Border1(
					arg.bound.upper.openFalseCloseTrue
					&& upperOped.bound.upper.openFalseCloseTrue
					,
					upperOped.bound.upper.mark
				);

				_bound = new Nonempty.En(lowerBorder, upperBorder);

			}
			//throw new NotImplementedException();
		}
	}
}
