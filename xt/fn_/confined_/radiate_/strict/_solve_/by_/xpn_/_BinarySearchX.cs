using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.xt.fn_.confined_.grow.solve_
{
	/// <summary>
	/// the function has to monotonic, strictly growing
	/// </summary>
	/// <see cref="nilnul.num.real.xt.fn_.grow.invert_.search_._BisectX"/>
    static public  class _BinarySearchX
    {
		
	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="grow"></param>
		/// <param name="expectedImage"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double? _Solve_2grow(double left,double right
			,
			Func<double,double> grow,double expectedImage=0
			) {

				if (grow(left)>expectedImage || grow(right)<expectedImage)
				{
					return null;
					
				}
				return _Solve_2grow_3solvable(left, right, grow, expectedImage );

		
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="func_monotone"></param>
		/// <param name="expected"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double _Solve_2grow_3solvable(
			 double left_imageLower,double right_imgHigher
			,
			Func<double, double> func_monotone, double expected = 0
			) {
				/// one is infinity, so the mid will not work
				/// <see cref="real.fn_.confined_.grow.solve_._BinarySearchX"/>
			
		}
    }
}
