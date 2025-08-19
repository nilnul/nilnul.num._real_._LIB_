using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.xt.fn_.confined_.neg2some_.grow.solve_
{
	/// <summary>
	/// the function has to monotonic, strictly upward growing
	/// </summary>
	/// <see cref="nilnul.num.real.xt.fn_.grow.invert_.search_._BisectX"/>
    static public  class _AccelerateSearchX
    {

		/// <summary>
		/// the scope is (-inf, <paramref name="right"/>);
		/// </summary>
		/// <param name="right"></param>
		/// <param name="_grow"></param>
		/// <param name="tgt">
		/// it is in ( f(-inf) , f(right)) ; so there must be a sln inner of the scope;
		/// </param>
		/// <param name="step"></param>
		/// <returns></returns>
		static public double _Search_1grow_2srcInner(double right, Func<double, double> _grow, double tgt
			, double step = 1
		///,  double _epsilon=double.Epsilon
		)
		{


			/// double step = 1;

			var left = right - step;
			var leftImg = _grow(left);

			double rightImg;

			while (tgt < leftImg)
			{

				right = left;
				rightImg = leftImg;

				left = left - (step *= 2);
				leftImg = _grow(left);
			}

			if (leftImg == tgt)
			{
				return left;
			}

			

			return nilnul.num.real.fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow_3srcInner(left, right, _grow, tgt);


		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="upward"></param>
		/// <param name="expectedImage"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double? _Solve_1grow(double right
			,
			Func<double,double> upward,double expectedImage=0
			) {


			var x = some2inf_.down.solve_._AccelerateSearchX._Solve_1down(
			   -right, x => upward(-x), expectedImage
		   );

			if (x is null)
			{
				return null;
			}
			return -x;

		}
	
    }
}
