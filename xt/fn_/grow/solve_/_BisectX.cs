using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.xt.fn_.grow.solve_
{

	/// <summary>
	/// for strict monotone. 
	/// </summary>
	/// <remarks>
	/// bisect: binary search for confined, accelerate search for radiate domain, <see cref="fn_.confined_.radiate_.strict._solve_.by_"/>
	/// </remarks>
	/// 
	/// this cannot use binary search as one border is infinity.
	/// we hop from one finite border, and step forward exponentially (accelerat), other than <see cref="nilnul.num.real.func"/>'s newton method which utilizes derivative to determine the step.
	///
	/// <see cref="nilnul.num.real.expr.equation.BinarySearchX"/>
	/// alias:
	///		bisect, utilizing both accelerate search and binary search.
	///  to use Newton method, we need derivative. So Newton search is deferred to a later project: nilnul.num.real._func_
	///		
	static public class _BisectX
	{
		/// <summary>
		/// the searched is in (lower, right) the open interval
		/// </summary>
		/// <param name="_grow"></param>
		/// <param name="tgt"></param>
		/// <param name="left"></param>
		/// <returns></returns>
		///

		[Obsolete(nameof(nilnul.num.real.fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow_3srcInner))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static double _Search_1innerTgts(Func<double, double> _grow, double tgt, double left,double right
			//, double _epsilon=double.Epsilon
		)
		{

			/// <see cref="nilnul.num.real.fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow_3srcInner(double, double, Func{double, double}, double)"/>
			///

			return nilnul.num.real.fn_.confined_.grow.solve_._BinarySearchX._Solve_2grow_3srcInner(left, right, _grow, tgt);

			//double middle=(right+left)/2;

			//while (right-left>_epsilon)
			//{
			//	middle = (left + right) / 2;
			//	var middleImg = _grow(middle);

			//	if (middleImg==tgt)
			//	{
			//		return middle;
			//	}
			//	if (middleImg<tgt)
			//	{
			//		left = middle;
			//	}
			//	else
			//	{
			//		right = middle;
			//	}

			//}

			//return middle;



		}

		/// <summary>
		/// the searched is in (left, +inf) the open interval;
		/// </summary>
		/// <param name="_grow"></param>
		/// <param name="tgt"></param>
		/// <param name="left">left of src, the right is infinity</param>
		/// <returns></returns>
		///
		[Obsolete(nameof(num.real.xt.fn_.confined_.some2inf_.grow.solve_._AccelerateSearchX._Search_1grow_2srcInner))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public double _Search_1gtLeftTgt(Func<double, double> _grow, double tgt, double left
			//, double _epsilon=double.Epsilon
		)
		{
			return num.real.xt.fn_.confined_.some2inf_.grow.solve_._AccelerateSearchX._Search_1grow_2srcInner(left,_grow,tgt);

			double step = 1;

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

			return _Search_1innerTgts(
				_grow,tgt,left,right//,_epsilon
			);
			

		}

		/// <summary>
		/// search in (-inf, right); don't include -inf, nor include 'right'
		/// ; the searched src is in the bound.
		/// </summary>
		/// <param name="_grow"></param>
		/// <param name="tgt"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		/// <see cref=""/>
		/// 
		// <param name="_epsilon"></param>
		/// 
		[Obsolete(nameof(num.real.xt.fn_.confined_.neg2some_.grow.solve_._AccelerateSearchX._Search_1grow_2srcInner))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _Search_1ltRightTgt(Func<double, double> _grow, double tgt, double right
			//, double _epsilon=double.Epsilon
		)
		{
			return num.real.xt.fn_.confined_.neg2some_.grow.solve_._AccelerateSearchX._Search_1grow_2srcInner(
				right
				,
				_grow
				,
				tgt
			);

			double step = 1;

			var left = right - step;
			var leftImg = _grow(left);

			double rightImg;

			while (tgt<leftImg)
			{

				right = left;
				rightImg = leftImg;

				left =left - (step*=2);
				leftImg = _grow(left);
			}

			if (leftImg==tgt)
			{
				return left;
			}

			return _Search_1innerTgts(
				_grow,tgt,left,right//,_epsilon
			);
			

		}


		static internal double _Search_0grow(Func<double, double> monotonic, double tgt, double negInfTgt, double infTgt
			//, double _epsilon=double.Epsilon
		)
		{
			if (tgt < negInfTgt || tgt > infTgt)
			{
				return double.NaN;
			}

			if (tgt == negInfTgt)
			{
				return double.NegativeInfinity;
			}
			if (tgt == infTgt)
			{
				return double.PositiveInfinity;
			}

			var middle = 0;

			var middleImg = monotonic(middle);

			if (tgt == middleImg)
			{
				return middle;
			}
			if (tgt < middleImg)
			{
				return _Search_1ltRightTgt(monotonic, tgt, middle//, _epsilon
				);
			}

			return _Search_1gtLeftTgt(monotonic,tgt,middle//,_epsilon
			);

		}


		static public double _Search_0grow(Func<double, double> monotonic, double tgt
			//,double _epsilon=double.Epsilon
		)
		{

			var left = double.NegativeInfinity;
			var right = double.PositiveInfinity;

			var leftImg = monotonic(left); ///might be infinity;
			var rightImg = monotonic(right); // might be infinity;

			return _Search_0grow(monotonic,tgt,leftImg,rightImg
				//,_epsilon
			);


		}

	}
}
