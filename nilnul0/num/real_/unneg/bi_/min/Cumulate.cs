using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.bi_.min
{
	/// <summary>
	/// <see cref="nilnul.obj.op_.binary.cumulator.be_.NilardableI{T}"/>
	/// </summary>
	/// VS:
	///		<see cref="num.real.xt_.nonneg.bi_.max"/>
	///		<see cref="num.real.xt_.nonneg.bi_.max._CumulateX"/>
	///		<see cref="nilnul.obj.op_.binary.cumulator.be_.INardable"/>
	///
	[Obsolete("this is nard, not unard. Hence it always return 0, rendering itself trivia use.",true)]
	static public class _CumulateX
	{
		/// <summary>
		/// this is nard, not unard.
		/// </summary>
		private const double _NARD = 0d;
		public static double SEED {
			get {
				return _NARD;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="nonnegs"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _Min_0nonnegs(
			//params
			IEnumerable<double> nonnegs
		) {
			return nonnegs.Aggregate(
#if DEBUG
	SEED
#else
	_NARD

#endif
				,
				(a,c) => Math.Min(a,c)
			);
		}
	}
}
