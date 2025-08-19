using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.xt.fn_.confined_.some2inf_.down.solve_
{
	/// <summary>
	/// the function has to monotonic, strictly downward
	/// </summary>
	/// <see cref="nilnul.num.real.xt.fn_.grow.invert_.search_._BisectX"/>
    static public  class _AccelerateSearchX
    {
		
	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="downward"></param>
		/// <param name="expectedImage"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double? _Solve_1down(double left
			,
			Func<double,double> downward,double expectedImage=0
			) {

			return some2inf_.grow.solve_._AccelerateSearchX._Solve_1grow(
				left, x => -downward(x),
				-expectedImage
			);

		
		}
	
    }
}
