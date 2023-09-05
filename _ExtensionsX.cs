using System;
using System.Collections.Generic;
using System.Linq;
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
