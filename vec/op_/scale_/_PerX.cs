using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.op_.scale_
{
	/// <summary>
	/// <see cref="nilnul.num.real.bi_.div_.IPer"/>
	/// ,when the divisor is nil, the component is undefined( might be inf, including: +inf, -inf)
	/// </summary>
	/// <seealso cref="nilnul.num.real.str.op_.unary_._ScaleX"/>
	static public class _PerX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b) Per(this in (double a, double b) vec, double x)
		{
			return (vec.a / x, vec.b / x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c) Per(this in (double a, double b, double c) vec, double x)
		{
			return (vec.a / x, vec.b / x, vec.c / x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c, double d) Per(this in (double a, double b, double c, double d) vec, double x)
		{
			return (vec.a / x, vec.b / x, vec.c / x, vec.d / x);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c, double d,double e) Per(this in (double a, double b, double c, double d, double e) vec, double x)
		{
			return (vec.a / x, vec.b / x, vec.c / x, vec.d / x, vec.e / x);


		}



	}
}
