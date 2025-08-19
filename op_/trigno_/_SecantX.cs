using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.trigno_
{
	///
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _SecantX
    {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public double Secant(double x) {
			return  1/ Math.Cos(x);
		}
    }

}
