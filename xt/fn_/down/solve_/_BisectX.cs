using nilnul.num.real.interval_.clopen_.closeLeft_;
using System;

namespace nilnul.num.real.xt.fn_.down.solve_
{

	/// <summary>
	/// for strict monotone downward
	/// </summary>
	/// 
	/// this cannot use binary search as one border is infinity.
	/// we hop from one finite border, and step forward exponentially (accelerat), other than <see cref="nilnul.num.real.func"/>'s newton method which utilizes derivative to determine the step.
	/// <see cref="nilnul.num.real.expr.equation.BinarySearchX"/>
	/// alias:
	///		accelerator search
	///		bisect
	static public class _BisectX
	{
		

		static internal double _Search_0down(Func<double, double> monotonic, double tgt, double negInfTgt, double infTgt
			//, double _epsilon=double.Epsilon
			)
		{
			return fn_.grow.solve_._BisectX._Search_0grow(
					x =>
					-monotonic(x), -tgt, -negInfTgt, -infTgt
					//, _epsilon
				);

		}


		static public double _Search_0down(Func<double, double> monotonic, double tgt
			//,double _epsilon=double.Epsilon
		)
		{
			return fn_.grow.solve_._BisectX._Search_0grow(
					x =>
					-monotonic(x), -tgt
					//,_epsilon
				);

		}

	}
}
