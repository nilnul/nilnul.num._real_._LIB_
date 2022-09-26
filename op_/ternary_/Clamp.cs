using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.ternary_
{
	/// <summary>
	/// a value clamped by a bound.
	/// borrowed from web.Css clamp
	/// </summary>
	public class Clamp
		:
		Ternary4dblI
	{
		/// <summary>
		/// a value clamed by a bound
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <returns>
		/// if y is less than x, return x; that is clamped to x
		/// if y is greater than z, return z.
		/// otherwiase return y.
		/// </returns>
		public double op(double x, double y, double z)
		{
			return Math.Max(
				x,
				Math.Min(
					y,z
				)
			);
		}
	}
}
