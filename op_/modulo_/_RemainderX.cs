using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.op_
{
	/// <summary>
	/// the remainder for x\1 
	/// </summary>
	/// <see cref="num.real_.floored._TailX.Doub(double)"/>
	/// 
	static public class _RemainderX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Remainder(double x) {
			return x- Math.Floor(x);
		}
		static public double Complement(double x) {
			return 1-Remainder(x);
		}
	}



}
