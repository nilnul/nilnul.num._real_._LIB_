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
using nilnul.num.quotient.co;

namespace nilnul.num.real.to_
{
	public static class _RadixX
	{
		static public Q1 _ClampAsQuotient2DigitsAftDot(this R r, uint digitsAftDot)
		{
			nilnul.num.RealIX._Clamp2DigitsAftDot(r, digitsAftDot);
			return r.current.midPoint;
		}

		static public Q4 _CinchAsQuotient2DigitsAftDot(this RealI_onQuotient r, int digitsAftDot)
		{
			nilnul.num.real._ExtensionsX._Cinch2DigitsAftDot(r, digitsAftDot);
			return r.current.Mid();
		}

		static public Q4 _CinchAsQuotient2DigitsAftDot(this RealI_onQuotient r, BigInteger digitsAftDot)
		{
			nilnul.num.real._ExtensionsX._Cinch2DigitsAftDot(r, digitsAftDot);
			return r.current.Mid();
		}

		static public Q4 _CinchAsQuotient2DigitsAftDot(this RealI_onQuotient r, uint digitsAftDot)
		{
			nilnul.num.real._ExtensionsX._Cinch2DigitsAftDot(r, digitsAftDot);
			return r.current.Mid();
		}

		static public Q1 _ClampAsQuotient2DigitsAftDot(this R r, BigInteger digitsAftDot)
		{
			nilnul.num.RealIX._Clamp2DigitsAftDot(r, digitsAftDot);
			return r.current.midPoint;
		}

		static public num.quotient_.radix_.Dec1 _Clamp2Dec_DigitsAftDot(this R r, uint digitsAftDot)
		{
			return nilnul.num.quotient_.radix_.Dec1.FroQuotient(
				_ClampAsQuotient2DigitsAftDot(r, digitsAftDot)
				, digitsAftDot
			);
		}

		static public num.quotient_.radix_.ByNeg _Cinc2Dec_DigitsAftDot(this RealI_onQuotient r, uint digitsAftDot)
		{
			return nilnul.num.quotient_.radix_.dec.of_.quotienty_._PerMantissaX.ToDec(
				_CinchAsQuotient2DigitsAftDot(r, digitsAftDot)
				, digitsAftDot
			);
		}

		static public num.quotient_.radix_.ByNeg _Cinc2Dec_1digitsAftDot(this RealI_onQuotient r, BigInteger digitsAftDot)
		{
			return nilnul.num.quotient_.radix_.dec.of_.quotienty_._PerMantissaX._ToDec_1mantissa(
				_CinchAsQuotient2DigitsAftDot(r, digitsAftDot)
				, digitsAftDot
			);
		}


		static public num.quotient_.radix_.Dec1 _Clamp2Dec_DigitsAftDot(this R r, BigInteger digitsAftDot)
		{
			return nilnul.num.quotient_.radix_.Dec1.FroQuotient(
				_ClampAsQuotient2DigitsAftDot(r, digitsAftDot)
				, digitsAftDot
			);
		}

	}
}
