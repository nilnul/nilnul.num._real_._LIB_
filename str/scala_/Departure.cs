using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.scala_
{
	/// <summary>
	/// the distance from origin to the point
	/// </summary>
	/// 
	///
	//[Obsolete("see nilnul.geometry.dimed.vect.co.Distance")]
	static public class _DepartureX
	{
		/// <summary>
		/// as in <see cref="nilnul.geometry.original"/>, which is a single point, where any point is 0 distance from origin;
		/// </summary>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure()
		{
			return 0;

			return Math.Sqrt(_VarianceX.Variance());
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure(double a)
		{
			return Math.Abs(a);
			return Math.Sqrt(_VarianceX.Variance(a));

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure(double a, double b)
		{
			return Math.Sqrt(str._VarianceX.Variance(a, b));
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure((double a, double b) x)
		{
			return Math.Sqrt(str._VarianceX.Variance(x));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure(double a, double b, double c)
		{
			return Math.Sqrt(str._VarianceX.Variance(a, b, c));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure((double a, double b, double c) x)
		{
			return Math.Sqrt(str._VarianceX.Variance(x));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure(double a, double b, double c, double d)
		{
			return Math.Sqrt(str._VarianceX.Variance(a, b, c, d));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure((double a, double b, double c, double d) x)
		{
			return Math.Sqrt(str._VarianceX.Variance(x));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure(double a, double b, double c, double d, double e)
		{
			return Math.Sqrt(str._VarianceX.Variance(a, b, c, d,e));
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure((double a, double b, double c, double d, double e) x)
		{
			return Math.Sqrt(str._VarianceX.Variance(x));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="reals"></param>
		/// <returns></returns>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Departure(IEnumerable<double> reals)
		{
			return Math.Sqrt(nilnul.num.real.str.to_.scalar_._SquareSumX.SquareSum(reals));
		}




	}
}
