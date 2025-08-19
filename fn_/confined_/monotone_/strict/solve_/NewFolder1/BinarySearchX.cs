using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.expr.equation
{
	/// <summary>
	/// the function has to monotonic.
	/// </summary>
	/// <see cref="nilnul.num.real.xt.fn_.grow.invert_.search_._BisectX"/>
	///
	[Obsolete(nameof(real.fn_.confined_.monotone_.strict.solve_._BinarySearchX))]
    public  class BinarySearchX
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

			return fn_.confined_.monotone_.strict.solve_._BinarySearchX._Solve_1right_2strict_3tgt(
				left,right,func, expectedImg);




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

			return fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow(left,right,func_monotone,expectedImage);
	

		
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

				
				return fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow_3srcInner(left_imageLower,right_imgHigher,func_monotone,expected);
		}
    }
}
