using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.tro
{
	static public class _ExtensionsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <see cref="nilnul.num.real.bi_.IDivide"/>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double, double, double) Divide(this (double,double,double)x, double y) {
			return (x.Item1/y,x.Item2/y,x.Item3/y);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  double Departure(this (double,double,double)x) {
			return Math.Sqrt(x.Variance());
		}

		[Obsolete(nameof(Departure))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  double Distance(this (double,double,double)x) {
			return Math.Sqrt(x.Variance());
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  double Variance(this (double,double,double)x) {
			return real.vec_.tro.Variance.Singleton.to(x);
		}


	}
}
