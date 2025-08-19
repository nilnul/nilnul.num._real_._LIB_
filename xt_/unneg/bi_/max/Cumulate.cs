using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.xt_.nonneg.bi_.max
{

	/// <summary>
	/// <see cref="nilnul.num.real.ext.op_.binary_.max.Cumulator4dbl"/>
	/// </summary>
	/// <see cref="num.real_.nonneg.bi_.min._CumulateX"/>
	/// <see cref="num.real_.nonneg.bi_.max.ICumulator"/>
	///

	[Obsolete(nameof(nilnul.num.real.ext.op_.binary_.max.Cumulator4dbl))]
	static public class _CumulateX
	{
		/// <summary>
		/// <see cref="ext.op_.binary_.max.Cumulator4dbl._UNARD"/>
		/// </summary>
		/// <see cref="nilnul.num.real.ext.op_.binary_.max.Cumulator4dbl._UNARD"/>
		 private const double _UNARD = double.NegativeInfinity;

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Seed {
			get {
				return _UNARD;
			}
		} 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _Max_0nonnegs(
			//params
			IEnumerable<double> nonnegs
		) {
			return nonnegs.Aggregate(
#if DEBUG1
				Seed
#else
	_UNARD

#endif
				,

				(a,c) => Math.Max(a,c) );
		}
	}
}
