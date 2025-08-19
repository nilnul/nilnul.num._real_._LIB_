using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.trigno_
{
	///en.wikipedia.org/wiki/Sinc_function
	///
	/// <summary>
	///  unnormalized version:
	///		sin(x) /x
	/// </summary>
	/// <remarks>
	/// the  integral of the unnormalized sinc function has a value of π
	/// </remarks>
	static public class _SincX
    {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public double Sinc(double x) {
			return x == 0 ? 1 : Math.Sin(x) / x;
		}
    }

}
