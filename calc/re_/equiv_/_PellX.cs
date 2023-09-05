using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.calc.re_.equiv_
{
	/// <summary>
	/// 
	/// </summary>
	internal class _PellX
	{
		/// <summary>
		/// this is the pell[n]
		/// </summary>
		/// <param name="n"></param>
		/// <returns>
		/// 0 for 0
		/// 1 for 1
		/// </returns>
		static public Real Pell(
			int n
		)
		{
			var sqrtTwo = nilnul.num.real.op_.unary_.Sqrt.Singleton.op_retReal(2);

			return ((1 + sqrtTwo) ^ n) - ((1 - sqrtTwo) ^ n)
				/
				(2 * sqrtTwo)
				;

		}
	}
}
