using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.op_.binary_.convolve
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		mean:
	///			expectation
	///				while avg is a simple dividing over the count;
	///	
	static public class _MovingMeanX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <param name="densities">
		/// eg:
		///		0.2,0.2,0.2,0.2,0.2
		///		0.1,0.2,0.4,0.2,0.1
		/// </param>
		/// <returns></returns>
		static public double[] _MovingMean_assumeStr_1Dist(
			IEnumerable<double> str
			,
			IEnumerable<double> densities
		) {
			return _ConvolveX._Convolute_assumesStr(
				str,
				densities
			);
		}
	

	}
}
