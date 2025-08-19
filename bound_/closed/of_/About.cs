using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.of_
{
   static public class _AboutX
    {
		/// <summary>
		/// betwixt [0.5x, 1.5x]
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public (double lower, double upper) About(double x) {
			if (x<0)
			{
				return (x * 1.5, x * .5);
			}
			return (x * .5, x * 1.5);
		}
    }
}
