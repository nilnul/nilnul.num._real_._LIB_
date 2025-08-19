using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{
	/// <summary>
	/// 
	/// </summary>
	internal class _HalveX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Halve(double x) {
			return x * .5; /// multi is much faster than division;
		}
	}
}
