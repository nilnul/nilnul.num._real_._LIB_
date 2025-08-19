using nilnul.num.quotient.co;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	static public class _ExtensionsX
	{
		static public void Clamp(
			this nilnul.num.RealI1 real
			,
			num.quotient_.DenomNonnil accuracy
		) {
			real.clamp(
				new quotient_.denomNonnil_.Positive(accuracy)
			);
		}

		static public void Cinch(
			this nilnul.num.RealI_onQuotient real
			,
			num.quotient_.DenomNonnil accuracy
		) {
			real.cinch(
				new quotient_.denomNonnil_.Positive(accuracy)
			);
		}

		static public Real_onQuotient ToImpl(
			this nilnul.num.RealI_onQuotient real
		) {
			return nilnul.num.Real_onQuotient.Of(real);
		}
		static public void CinchHalf(this nilnul.num.RealI_onQuotient x)
		{
			if (x.current.begin != x.current.end )
			{
				x.cinch(new nilnul.num.quotient_.denomNonnil_.Positive(x.current.Diameter() / 2));
			}
		}
		static public void _CinchHalf_0spanned(this nilnul.num.RealI_onQuotient x)
		{
			
				x.cinch(new nilnul.num.quotient_.denomNonnil_.Positive(x.current.Diameter() / 2));
			
		}


		static public void _Cinch2UnitFrac(this RealI_onQuotient x, BigInteger denominator_positive)
		{

			Cinch(
				x
				,
				nilnul.num.quotient_.DenomNonnil.Inverse(denominator_positive)
			);


		}

		static public void _Cinch2DigitsAftDot(this RealI_onQuotient x, BigInteger digitsAftDot)
		{
			x._Cinch2UnitFrac(
				nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(10, digitsAftDot)


			);

		}


		static public void ClampOfInversal(
			this nilnul.num.RealI1 real
			,
			int x
		) {
			real.Clamp(
				 quotient_.DenomNonnil.Inverse(x)
			);
		}



	}
}
