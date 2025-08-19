using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.xt.fn_.confined_.neg2some_.down.solve_
{
	/// <summary>
	/// the function has to monotonic, strictly downward;
	/// the scope is [-inf, a]
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
		static public double? _Solve_1downward(double right
			,
			Func<double,double> downward,double expectedImage=0
			) {


			 var x= some2inf_.grow.solve_._AccelerateSearchX._Solve_1grow(
				-right, x=> downward(-x),expectedImage
			);
			if (x is null)
			{
				return null;
			}
			return -x;
		}
	
    }
}
