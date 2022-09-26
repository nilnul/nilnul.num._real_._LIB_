using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.expr.equation
{
	/// <summary>
	/// the function has to monotonic.
	/// </summary>
    public partial class BinarySearchX
    {
		/// <summary>
		/// equation must be monotonic
		/// </summary>
		/// <param name="func"></param>
		/// <param name="expectedImg"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double? _Solve(Func<double, double> func, double expectedImg, double left, double right)
		{

			//check the monotonic
			if (func(left) > func(right))
			{
				return _Solve_funcMonotone((x => -func(x)), -expectedImg, left, right);


			}
			return _Solve_funcMonotone(func, expectedImg, left, right);



		}
	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="func_monotone"></param>
		/// <param name="expectedImage"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double? _Solve_funcMonotone(
			Func<double,double> func_monotone,double expectedImage,double left,double right
			) {

				if (func_monotone(left)>expectedImage || func_monotone(right)<expectedImage)
				{
					return null;
					
				}
				return _Solve_funcMonotone_leftImgLower_rightImgHigher(func_monotone, expectedImage, left, right);

		
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="func_monotone"></param>
		/// <param name="expected"></param>
		/// <param name="interval"></param>
		/// <returns></returns>
		static public double _Solve_funcMonotone_leftImgLower_rightImgHigher(
			Func<double, double> func_monotone, double expected, double left_imageLower,double right_imgHigher
			) {

				var middle = (left_imageLower + right_imgHigher)/2;
				if (middle<=left_imageLower || middle>=right_imgHigher)
				{
					return middle;
				}

				var middleImage = func_monotone(middle);
				if (middleImage>expected)
				{
					return _Solve_funcMonotone_leftImgLower_rightImgHigher(func_monotone, expected, left_imageLower, middle);
				}
				if (middleImage<expected)
				{
					return _Solve_funcMonotone_leftImgLower_rightImgHigher(func_monotone, expected, middle, right_imgHigher);
				}
				return middle;
		}
    }
}
