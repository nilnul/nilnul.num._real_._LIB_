using nilnul.num.quotient.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using Q1 = nilnul.num.Quotient1;

using R = nilnul.num.RealI;
using System.Numerics;

namespace nilnul.num.real.to_
{
	public static class _QuotientX
	{
		static public Q1 _ClampAsQuotient2DigitsAftDot(this R r, uint digitsAftDot)
		{
			nilnul.num.RealIX._Clamp2DigitsAftDot(r, digitsAftDot);
			return r.current.midPoint;
		}
		static public Q1 _ClampAsQuotient2DigitsAftDot(this R r, BigInteger digitsAftDot)
		{
			nilnul.num.RealIX._Clamp2DigitsAftDot(r, digitsAftDot);
			return r.current.midPoint;
		}

	

	}
}
