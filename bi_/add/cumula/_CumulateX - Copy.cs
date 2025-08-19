using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real.bi_.add.cumula
{
	static public class _CumulateX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public R Cumulate(IEnumerable<R> summands) {
			return summands.Aggregate(
				(R)nilnul.num.real_.Quotient_denomNonnil.Nil
				,
				nilnul.num.real.bi_.Add.Singleton.op
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Cumulate(IEnumerable<double> summands) {
			return summands.Aggregate(
				0d
				,
				nilnul.num.real.bi_.Add.Singleton.op
			);
		}


	}
}
