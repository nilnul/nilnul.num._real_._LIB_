using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q0 = nilnul.num.Quotient1;
using R = nilnul.num.RealI2;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.op_.unary_
{
	static public class _ScaleX
	{

		static public A Scale(this A r, Q0 scale) {

			if (scale==0)
			{
				return new nilnul.num._real._cauchy.approach_.Quotient();

			}
			return new _scale.ret_.ScaleNonnil(scale,r);

		}

		static public A Div(this A r, Q0 scale) {

			return Scale(r, 1/scale);

		}




		public static A Scale(Q0 quotient1, A approachI)
		{
			return Scale(approachI, quotient1);

		}
	}
}
