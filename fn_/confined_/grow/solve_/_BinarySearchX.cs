using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.fn_.confined_.grow.solve_
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
			Func<double,double> grow,double expectedImage
			) {

			double leftTgt = grow(left);
			double rightTgt = grow(right);

			if (leftTgt > expectedImage || rightTgt < expectedImage)
				{
					return null;
					
			}

			if (leftTgt == expectedImage)
			{
				return left;
			}
			if (rightTgt == expectedImage)
			{
				return right;
			}

			return _Solve_2grow_3srcInner(left, right, grow, expectedImage );

		
		}
		/// <summary>
		/// the src is inner, not on the border.
		/// </summary>
		/// <param name="func_monotone"></param>
		/// <param name="expected"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double _Solve_2grow_3srcInner(
			 double left_imageLower,double right_imgHigher
			,
			Func<double, double> func_monotone, double expected
			) {

				var middle = (left_imageLower + right_imgHigher)/2;
				if (middle<=left_imageLower || middle>=right_imgHigher)
				{
					return middle;
				}

				var middleImage = func_monotone(middle);
				if (middleImage>expected)
				{
					return _Solve_2grow_3srcInner(left_imageLower, middle,func_monotone, expected);
				}
				if (middleImage<expected)
				{
					return _Solve_2grow_3srcInner(middle, right_imgHigher,func_monotone, expected );
				}
				return middle;
		}
    }
}
