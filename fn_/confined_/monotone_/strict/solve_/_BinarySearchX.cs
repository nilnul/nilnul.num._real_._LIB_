using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.fn_.confined_.monotone_.strict.solve_
{
	/// <summary>
	/// the function has to monotonic.
	/// </summary>
	/// <see cref="nilnul.num.real.xt.fn_.grow.invert_.search_._BisectX"/>
    static public  class _BinarySearchX
    {
		/// <summary>
		/// equation must be monotonic
		/// </summary>
		/// <param name="func"></param>
		/// <param name="expectedImg"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double? _Solve_1right_2strict_3tgt(double left, double right,Func<double, double> func, double expectedImg )
		{

			//check the monotonic
			if (func(left) > func(right))
			{
				return fn_.confined_.grow.solve_._BinarySearchX. _Solve_2grow(left, right,(x => -func(x)), -expectedImg );


			}

			return fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow(left, right,func, expectedImg );



		}
	

    }
}
