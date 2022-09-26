using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real.op
{
	public class Ceil
	{
		static public BigInteger Eval(R x)
		{

			var t = nilnul.num.quotient.bound.Lower.Ceil_infermum(x.interval.val.lower);

			var t2 = nilnul.num.quotient.bound.Upper.Ceil_supremum(x.interval.val.upper);

			while (t != t2)
			{
				x.ConvergeHalf();

				t = nilnul.num.quotient.bound.Lower.Ceil_infermum(x.interval.val.lower);

				t2 = nilnul.num.quotient.bound.Upper.Ceil_supremum(x.interval.val.upper);

			}

			return t;
		}
	}
}
