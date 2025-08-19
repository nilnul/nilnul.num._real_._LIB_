using System;

namespace nilnul.num.real.xt.fn_.monotone_.strict.solve_
{

	/// <summary>
	/// for strict monotone
	/// </summary>
	/// <remarks>
	/// this cannot uses <see cref="nilnul.num.real.fn_.confined_.monotone_.strict.solve_._BinarySearchX"/> as one border is infinity.
	/// </remarks>
	///  vs:
	///		<see cref="xt.fn_.demiaxis_.strict.IAccelerateSearch"/>, while this has to be bisected to unifinite, and then use that.
	/// <see cref="nilnul.num.real.expr.equation.BinarySearchX"/>
	static public class _BisectX
	{

		static public double _Search_0monotone(Func<double, double> monotonic, double tgt
			//, double _epsilon = double.Epsilon
			)
		{

			var left = double.NegativeInfinity;
			var right = double.PositiveInfinity;

			var leftImg = monotonic(left); ///might be infinity;
			var rightImg = monotonic(right); // might be infinity;

			if (leftImg>rightImg)
			{
				return fn_.down.solve_._BisectX._Search_0down(
					x=>
					-monotonic(x),-tgt,-leftImg,-rightImg
					//, _epsilon
				);

				return fn_.grow.solve_._BisectX._Search_0grow(
					x=>
					-monotonic(x),-tgt,-leftImg,-rightImg
					//, _epsilon
				);

			}
			/// the two cannot be equal as it's strict;

			return fn_.grow.solve_._BisectX._Search_0grow(monotonic,tgt,leftImg,rightImg
				//,_epsilon
				);


			

		}



	}
}
