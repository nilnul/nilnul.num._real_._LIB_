using System;

namespace nilnul.num.real.trans_.grow_.ergodic.invert_.search_
{

	/// <summary>
	/// the tgt for -inf is -inf, for +inf is +inf
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// <see cref="nilnul.num.real.ext.trans_.grow.invert_.search_._BisectX"/>:
	///			
	/// <see cref="nilnul.num.real.expr.equation.BinarySearchX"/>
	static public class _BisectX
	{
		static internal double _Search_0grow(
			Func<double, double> monotonic
			,
			double tgt
			,
			double _epsilon=double.Epsilon
		)
		{

			var middle = 0;

			var middleImg = monotonic(middle);

			if (tgt == middleImg)
			{
				return middle;
			}

			if (tgt < middleImg)
			{
				return  real.ext.trans_.grow.invert_.search_._BisectX. _Search_1ltRightTgt(monotonic, tgt, middle, _epsilon);
			}

			return real.ext.trans_.grow.invert_.search_._BisectX._Search_1gtLeftTgt(monotonic,tgt,middle,_epsilon);

		}
	}
}
