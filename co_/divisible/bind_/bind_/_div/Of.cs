using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Approach1 = nilnul.num._real.ApproachI1;
using nilnul.num.real;
using nilnul.num.quotient.border.duo.be_;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.duo_.divisible.bind_._div
{


	public class Of :
		A
	{


		private A _dividend;

		public A dividend
		{
			get { return _dividend; }
			set { _dividend = value; }
		}

		private approach_.NonnilI _divisor;

		public approach_.NonnilI divisor
		{
			get { return _divisor; }
			set { _divisor = value; }
		}

		private A _multiExpr;

		public Of(A a, approach_.NonnilI b)
		{

			this._dividend = a;
			this._divisor = b;


			_multiExpr = approach.op_.binary_._MultiX.Op(
				_dividend,

				 approach_.nonnil.op_.unary_.inverse_.by_._OneMinusProperInverseExpansionX.Approach(_divisor)
			);
		}








		public nilnul.num.quotient.Range1 range
		{
			get
			{
				return _multiExpr.range;
			}
		}

		public void squeeze(quotient_.Positive1 diameter)
		{
			_multiExpr.squeeze(diameter);
			return;
		}
	}
}
