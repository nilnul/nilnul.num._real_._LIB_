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
	internal class _FibonacciX
	{
		/// <summary>
		/// this is the finonacci[n]
		/// </summary>
		/// <param name="n"></param>
		/// <returns>
		/// 0 for 0
		/// 1 for 1
		/// </returns>
		static public Real Fibonacci(
			int n
		) {

			return ( nilnul.num.real_.GoldenRatio.Singleton.ToImpl() ^ n) - ( (-nilnul.num.real_.GoldenRatio.Singleton.ToImpl()) ^ n )
				/ nilnul.num.real_.nonneg.op_.unary_.Sqrt.Singleton.op(5)
				;

		}
	}
}
