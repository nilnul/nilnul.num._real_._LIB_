using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Approach1 = nilnul.num._real.ApproachI1;
using nilnul.num.real;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.duo_.divisible.op_._divide
{




	public class Call :


		ApproachI1

	{


		private ApproachI1 _dividend;

		public ApproachI1 dividend
		{
			get { return _dividend; }
			set { _dividend = value; }
		}

		private approach.be_.Nonzero.En _divisor;

		public approach.be_.Nonzero.En divisor
		{
			get { return _divisor; }
			set { _divisor = value; }
		}

		private ApproachI1 _multiExpr;

		public Call(ApproachI1 a, approach.be_.Nonzero.En b)
		{

			this._dividend = a;
			this._divisor = b;


			_multiExpr = duo.op_.Multi.Eval(
				_dividend,

				new approach_.nonzero.op_._inverse.Ret(_divisor)
			);
		}








		public Nonempty.En bound
		{
			get
			{
				return _multiExpr.bound;
				throw new NotImplementedException();
			}
		}

		public void clamp(quotient.be_.Positive1.En diameter)
		{
			_multiExpr.clamp(diameter);
			return;
			throw new NotImplementedException();
		}
	}
}
