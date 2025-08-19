using System;

namespace nilnul.num.real.bi_
{
	/// <summary>
	/// note the order of the arguments is reversed in comparison with <see cref="Math.Log(double, double)"/>
	/// </summary>
	static public class _LogarithmX
	{
		/// <summary>
		/// <see cref=""/>
		/// </summary>
		/// <param name="basicand"></param>
		/// <param name="antiLogarithm"></param>
		/// <returns>
		///
		/// </returns>
		static public double Logarithm(double basicand, double antiLogarithm) {
			return Math.Log(  antiLogarithm , basicand);
		}
	}


}
