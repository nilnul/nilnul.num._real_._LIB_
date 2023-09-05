using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.op_.binary_.convolve.movingMean_
{
	/// <summary>
	/// 
	/// </summary>
	///	
	static public class _AvgX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <param name="count">
		/// how many terms are count; the width of the window;
		/// </param>
		/// <returns></returns>
		static public double[] _MovingAvg_assumeStr_1Positive(
			IEnumerable<double> str
			,
			int count
		) {

			return _MovingMeanX. _MovingMean_assumeStr_1Dist(
				str
				,
				
				nilnul.obj.str.of_._RepeatX._Repeat_1nonneg(
					1d/count
					,
					count
				)
			);
		}


	}
}
