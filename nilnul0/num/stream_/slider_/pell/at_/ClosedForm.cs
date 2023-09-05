using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.slider_.pell.at_
{
	/// pi.math.cornell.edu/~gautam/ContinuedFractions.pdf
	/// p27
	/// def5.7;
	/// <summary>
	/// 
	/// </summary>
	internal class ClosedForm
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns>
		/// 0 for 0;
		/// 1 for 1
		/// </returns>
		static public double OfIndex(int x) {
			var sqrtTwo = num.real_.eg_.sqrt_._OfTwoX.DBL; 
			return (Math.Pow(1 + sqrtTwo, x) - Math.Pow(1 - sqrtTwo, x) )
				/
				(2 * sqrtTwo)
			;
		}
	}
}
