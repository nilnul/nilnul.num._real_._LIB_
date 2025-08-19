using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul.num.real.str_.started
{
	public static  class _MinX
	{
		/// <summary>
		/// assume started
		/// </summary>
		/// <param name="doubleS_headed">
		/// started.
		/// </param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Min(IEnumerable<double> doubleS_headed) {

			return doubleS_headed.Count()==1 ?
				doubleS_headed.First() : Math.Min(doubleS_headed.First(),Min(doubleS_headed.Skip(1)));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Min(params double[] doubleS_noEmpty) {
			return Min(doubleS_noEmpty as IEnumerable<double>);
			
		}

		static public int _Index_0started(
			IEnumerable<double> doubleS_headed
		)
		{
			var r = 0;

			int length = doubleS_headed.Count();

			for (int i = 1; i < length; i++)
			{
				if (doubleS_headed.ElementAt(i) < doubleS_headed.ElementAt(r))
				{
					r = i;
				}
			}
			return r;

		}
	}
}
