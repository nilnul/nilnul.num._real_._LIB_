using System;

namespace nilnul.num.real.fn_.grow_.ergodic.solve_
{

	/// <summary>
	/// the tgt for -inf is -inf, for +inf is +inf
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// <see cref="nilnul.num.real.xt.fn_.grow.invert_.search_._BisectX"/>:
	///			
	/// <see cref="nilnul.num.real.expr.equation.BinarySearchX"/>
	static public class _BisectX
	{
		static internal double _Search_0grow(
			Func<double, double> monotonic
			,
			double tgt
			//,			double _epsilon=double.Epsilon
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
				return  real.xt.fn_.grow.solve_._BisectX. _Search_1ltRightTgt(monotonic, tgt, middle
					//, _epsilon
					);
			}

			return real.xt.fn_.grow.solve_._BisectX._Search_1gtLeftTgt(monotonic,tgt,middle
				//,_epsilon
				);

		}
	}
}
