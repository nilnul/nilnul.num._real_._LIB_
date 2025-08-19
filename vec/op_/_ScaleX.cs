using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="nilnul.num.real.str.op_.unary_._ScaleX"/>
	static public class _ScaleX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b) Scale(this in (double a, double b) vec, double x)
		{
			return (vec.a * x, vec.b * x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c) Scale(this in (double a, double b, double c) vec, double x)
		{
			return (vec.a * x, vec.b * x, vec.c * x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c, double d) Scale(this in (double a, double b, double c, double d) vec, double x)
		{
			return (vec.a * x, vec.b * x, vec.c * x, vec.d * x);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c, double d,double e) Scale(this in (double a, double b, double c, double d, double e) vec, double x)
		{
			return (vec.a * x, vec.b * x, vec.c * x, vec.d * x, vec.e*x);


		}



	}
}
