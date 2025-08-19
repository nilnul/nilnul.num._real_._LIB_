using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.str
{
	[Obsolete(nameof(str.IPotence))]
	static public class _VarianceX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance()
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance(double x)
		{
			return x * x;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance(double x, double y)
		{
			return x * x + y * y;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance((double x, double y) a)
		{
			return Variance(a.x,a.y);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance(double x, double y, double z)
		{
			return x * x + y * y + z * z;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance((double x, double y, double z) a)
		{
			return Variance(a.x,a.y,a.z);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// used by quaternion
		/// </remarks>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance(double a, double b, double c, double d)
		{
			return a * a + b * b + c * c + d * d;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance((double a, double b, double c, double d) x)
		{
			return Variance(x.a,x.b,x.c, x.d);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance(double a, double b, double c, double d, double e)
		{
			return a * a + b * b + c * c + d * d + e*e;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance((double a, double b, double c, double d, double e) x)
		{
			return Variance(x.a,x.b,x.c,x.d,x.e);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Variance(IEnumerable<double> reals)
		{
			return nilnul.num.real.str.to_.scalar_._SquareSumX.SquareSum(reals);
		}



	}


}
