using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.xt.fn_.confined_.some2inf_.grow.solve_
{
	/// <summary>
	/// the function has to monotonic, strictly growing
	/// </summary>
	/// <see cref="nilnul.num.real.xt.fn_.grow.invert_.search_._BisectX"/>
	/// Newton method needs derivatives, so it's deferred to a later project: nilnul.num.real._func_
	///
	/// vs:
	///		<see cref="num.real.xt.fn_.monotone_.strict.solve_._BisectX"/> ,<see cref="fn_.confined_.radiate_.strict._solve_.by_"/>
    static public  class _AccelerateSearchX
    {

		/// <summary>
		/// the bound is: (left, +inf)
		/// ;
		/// the expectedTgt is with (f(left), f(+inf) ), hence the searched src is in the bound
		/// </summary>
		/// <param name="left">
		/// the left open border
		/// </param>
		/// <param name="_grow"></param>
		/// <param name="tgt">
		/// the expected tgt;
		/// </param>
		/// <param name="step">
		/// the step can also be determined by derivative; but that algorithm is deferred to <see cref="nilnul.num.real._func_"/>
		/// </param>
		/// 
		/// <returns></returns>
		///

		// <param name="_epsilon"></param>

		static public double _Search_1grow_2srcInner(double left,Func<double, double> _grow, double tgt
			,double step=1
			///,  double _epsilon=double.Epsilon
		)
		{
		

			/// double step = 1;

			var right = left + step;
			var rightImg = _grow(right);

			double leftImg;

			while (tgt>rightImg)
			{

				left = right;
				leftImg = rightImg;

				right =right + ( step*= 2 );
				rightImg = _grow(right);
			}

			if (rightImg==tgt)
			{
				return right;
			}

			return nilnul.num.real.fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow_3srcInner(left, right, _grow, tgt);
			

		}

		
	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="grow"></param>
		/// <param name="expectedImage"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double? _Solve_1grow(double left
			,
			Func<double,double> grow
			,
			double expectedImage=0
		) {

			double leftTgt = grow(left);
			double rightTgt = grow(double.PositiveInfinity);

			if (leftTgt > expectedImage || rightTgt < expectedImage)
				{
					return null;
					
				}
			if (leftTgt == expectedImage)
			{
				return left;
			}
			if (rightTgt ==expectedImage)
			{
				return rightTgt;
			}

			return _Search_1grow_2srcInner(left,grow,expectedImage);

			return nilnul.num.real.xt.fn_.grow.solve_._BisectX._Search_1gtLeftTgt(  grow, expectedImage,left );

		
		}
	
    }
}
