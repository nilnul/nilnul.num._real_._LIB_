using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.op_.modulo_
{
	/// <summary>
	/// morph the axis into opposite direction, then get the remainder;
	/// </summary>
	static public class _LackX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Lack(double x) {
			return Math.Ceiling(x) -x; /// [0,1)
			return _RemainderX.Remainder(-x);


		}
		static public double Complement(double x) {
			return 1 - Lack(x);

		}
	}



}
