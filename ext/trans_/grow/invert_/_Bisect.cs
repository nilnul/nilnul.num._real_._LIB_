using System;

namespace nilnul.num.real.ext.trans_.grow.invert_.search_
{

	/// <summary>
	/// for strict monotone
	/// </summary>
	/// <see cref="nilnul.num.real.expr.equation.BinarySearchX"/>
	static public class _BisectX
	{
		static internal double _Search_0grow(Func<double, double> monotonic, double tgt, double negInfTgt, double infTgt, double _epsilon=double.Epsilon)
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
				return _Search_1ltRightTgt(monotonic, tgt, middle, _epsilon);
			}

			return _Search_1gtLeftTgt(monotonic,tgt,middle,_epsilon);

		}


		static public double _Search_0grow(Func<double, double> monotonic, double tgt,double _epsilon=double.Epsilon)
		{

			var left = double.NegativeInfinity;
			var right = double.PositiveInfinity;

			var leftImg = monotonic(left); ///might be infinity;
			var rightImg = monotonic(right); // might be infinity;

			return _Search_0grow(monotonic,tgt,leftImg,rightImg,_epsilon);


		}

		/// <summary>
		/// the searched is in (left, +inf); 
		/// </summary>
		/// <param name="_grow"></param>
		/// <param name="tgt"></param>
		/// <param name="left"></param>
		/// <returns></returns>
		static public double _Search_1gtLeftTgt(Func<double, double> _grow, double tgt, double left, double _epsilon)
		{
		

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
				_grow,tgt,left,right,_epsilon
			);
			

		}

		/// <summary>
		/// search in (-inf, right); don't include -inf, nor include 'right'
		/// </summary>
		/// <param name="_grow"></param>
		/// <param name="tgt"></param>
		/// <param name="right"></param>
		/// <param name="_epsilon"></param>
		/// <returns></returns>
		static public double _Search_1ltRightTgt(Func<double, double> _grow, double tgt, double right, double _epsilon)
		{

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
				_grow,tgt,left,right,_epsilon
			);
			

		}
		/// <summary>
		/// the searched is in (lower, +inf); 
		/// </summary>
		/// <param name="_grow"></param>
		/// <param name="tgt"></param>
		/// <param name="left"></param>
		/// <returns></returns>
		static double _Search_1innerTgts(Func<double, double> _grow, double tgt, double left,double right, double _epsilon)
		{

			double middle=(right+left)/2;

			while (right-left>_epsilon)
			{
				middle = (left + right) / 2;
				var middleImg = _grow(middle);

				if (middleImg==tgt)
				{
					return middle;
				}
				if (middleImg<tgt)
				{
					left = middle;
				}
				else
				{
					right = middle;
				}

			}

			return middle;



		}
	}
}
