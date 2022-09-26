using nilnul.num.quotient.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;
namespace nilnul.num.real.to_
{
	[Obsolete()]
	public static class RadixX
	{
		static public nilnul.num.quotient.radix.Dec ToDec(R r , uint digitsAftDot_nonNeg) {

			return Dec.FroQuotient( r._ClampAsQ2DigitsAftDot( digitsAftDot_nonNeg),  digitsAftDot_nonNeg);
		}

	}
}
