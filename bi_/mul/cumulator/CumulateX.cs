using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bi_.mul.cumulator
{
	static public class _CumulateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="factors">
		/// each term is called factor
		/// </param>
		/// <returns></returns>
		static public double Cumulate(IEnumerable<double> factors) {
			return factors.Aggregate(
				1d
				,
				(a,c) => a*c
			);
		}
	}
}
