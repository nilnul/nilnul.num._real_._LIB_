using System;

namespace nilnul.num.real.ext.trans_.monotone_.strict.invert_.search_
{

	/// <summary>
	/// for strict monotone
	/// </summary>
	/// <see cref="nilnul.num.real.expr.equation.BinarySearchX"/>
	static public class _BisectX
	{

		static public double _Search_0monotone(Func<double, double> monotonic, double tgt, double _epsilon = double.Epsilon)
		{

			var left = double.NegativeInfinity;
			var right = double.PositiveInfinity;

			var leftImg = monotonic(left); ///might be infinity;
			var rightImg = monotonic(right); // might be infinity;

			if (leftImg>rightImg)
			{
				return trans_.grow.invert_.search_._BisectX._Search_0grow(
					x=>
					-monotonic(x),-tgt,-leftImg,-rightImg, _epsilon
				);
			}
			/// the two cannot be equal as it's strict;

			return trans_.grow.invert_.search_._BisectX._Search_0grow(monotonic,tgt,leftImg,rightImg,_epsilon);


			

		}



	}
}
