using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using N = nilnul.num.natural.Natural_bigInteger;

using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.RealI3;

namespace nilnul.num.real.op_.unary_
{
	static public  class _SquareX
	{
		static public double Double(double x) {
			return x * x;
		}

		static public R Real(R x) {
			return new _square.Of(x);
		}
	}
}
