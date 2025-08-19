using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///<see cref="nameof(real.co_.starT_.positive._PowX)"/>
	/// </remarks>
	public interface PowerI
	{
	}
	static public class _PowX
	{

		//static public nilnul.num.RealI Op_radicAssumePositive(nilnul.num.RealI x, nilnul.num.RealI y) {
		//	return real.co_.starT_.positive._PowX.RetRealI_assumeRadicPositive(x, y);
		//}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <exception cref="">
		///		radic must be positive. (if radic is negative, only quotient index is allowed to remain within the realm of real numbers, not overflowing into complex numbers. and the determinant of that quotient must be odd)
		/// </exception>
		static public nilnul.num.RealI Op(nilnul.num.RealI x, nilnul.num.RealI y)
		{
			return real.co_.starT_.positive._PowX.RetRealI(x, y);
		}
	}
}
