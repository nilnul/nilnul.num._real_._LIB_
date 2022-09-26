using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positive_.ltOne.coerce_.quotient_.unital_
{
	/// <summary>
	/// convert to a unital quotient
	/// </summary>
	static public class _FloorX
	{
		
		static public long DenominatorOfFloor_assumePositiveLtOne(double x) {
			var inverted = 1 / x;
			return (long) Math.Ceiling(inverted);

		}


	}
}
