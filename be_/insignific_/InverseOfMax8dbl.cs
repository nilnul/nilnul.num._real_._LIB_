#if DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.insignific_
{

	/// <summary>
	/// <see cref="double"/> is in the form of +-mantissa*2^indicand, hence it's minValue in absolute is equal to maxValue;
	/// </summary>
	static public class _LtInverseMax8dblX
    {
		/// <summary>
		/// when inversed again, it's +inf
		/// </summary>
		public const double InverseOfMax = 1d / double.MaxValue; 
		static public bool Be(double x) {
			//var inverseOfMax = 1d / double.MaxValue;	/// a finite number.  in other words, 1/inverseOfMax = double.MaxValue lt inverseOfEpsilon, hence inverseOfMax gt epsilon, this in agreement with the purpose of epsilon: the most insignificant number.

			//var inverseOfEpsilon =1d/ double.Epsilon;   /// this is infinity

			return Math.Abs(x) < InverseOfMax; /// when x = inverseOfMax, its inverse is finite, still effective.

		}
    }
}
#endif
