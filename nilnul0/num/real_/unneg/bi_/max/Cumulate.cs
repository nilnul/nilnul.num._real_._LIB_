using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.bi_.max
{
	/// <summary>
	/// <see cref="nilnul.obj.op_.binary.cumulator_.IUnardable"/>
	/// </summary>
	/// VS:
	///		<see cref="num.real.xt_.nonneg.bi_.max._CumulateX"/>
	///	
	static public class _CumulateX
	{
		/// <summary>
		/// this is unard, not nard.
		/// </summary>
		private const double _UNARD = 0d;
		public static double SEED {
			get {
				return _UNARD;
			}
		}

		/// <summary>
		/// used in, say, <see cref="nilnul.task.prj.sample.Cpm"/>, where the early start time is the max of the end time of all previous tasks;
		/// </summary>
		/// <param name="nonnegs"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _Max_0nonnegs(
			//params
			IEnumerable<double> nonnegs
		) {
			return nonnegs.Aggregate(
#if DEBUG
	SEED
#else
	_UNARD

#endif
				,
				(a,c) => Math.Max(a,c)
			);
		}
	}
}
