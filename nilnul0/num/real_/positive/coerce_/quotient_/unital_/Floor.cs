using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positive.coerce_.quotient_.unital_
{
	/// <summary>
	/// convert to a unital quotient
	/// </summary>
	static public class _FloorX
	{
		static public nilnul.num.Quotient1 Floor(nilnul.num.real_.PositiveDbl x) {
			return Floor_assumePositive(x.ee);
		}
		static public nilnul.num.Quotient1 Floor_assumePositive(double x) {
			if (x>=1)
			{
				return new Quotient1( (long) Math.Floor(x) );
			}
			return nilnul.num.Quotient1.CreateUnit(num.real_.positive_.ltOne.coerce_.quotient_.unital_._FloorX.DenominatorOfFloor_assumePositiveLtOne(x) );
			

		}


	}
}
