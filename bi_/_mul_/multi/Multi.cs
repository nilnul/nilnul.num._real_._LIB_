using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;
using Q0 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using R1 = nilnul.num.RealI2;

namespace nilnul.num._real._cauchy.approach.op_.binary_
{
	static public  class _MultiX
	{


		public const char Sign = '*';

		static public A Op(A a, A b)
		{

			return new _multi.Ret(a, b);


		}
		static public A Op(Q0 a, A b)
		{
			return op_.unary_._ScaleX.Scale(b, a);

		}

		static public A Square(A a)
		{
			return Op(a, a);
		}

	}
	
}
