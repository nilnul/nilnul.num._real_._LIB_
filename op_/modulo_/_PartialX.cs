using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.op_.modulo_
{
	/// <summary>
	/// <see cref="num.real.bound_.unial_.Parture4dbl"/>
	/// <see cref="num.real.bound_.unital_.Partial4dbl_openClose"/>
	/// <see cref="num.real.bound_.fuzzy_.IPotential"/>
	/// </summary>
	static public class _PartialX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Partial(double x) {
			var t= x- Math.Floor(x);
			if (t==0)
			{
				return 1;

			}
			return t;
		}
	}



}
