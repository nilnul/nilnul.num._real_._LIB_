using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.to_.quotient_.radix_
{
	static public class _DecX
	{
		static public nilnul.num.quotient_.radix.recur_.Dec ToDecRecur(
			nilnul.num.RealI real,  uint digitsAftDot
		)
		{
				return nilnul.num.quotient_.radix.recur_.Dec.FroQuotient(
					nilnul.num.real.to_._QuotientX._ClampAsQuotient2DigitsAftDot(real, digitsAftDot)
					
				);
			}
		}
}
