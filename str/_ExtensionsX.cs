using System.Collections.Generic;
using System.Runtime.CompilerServices;
using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real.str
{
	static public class _ExtensionsX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public R Sum(this IEnumerable<R> seq) {
			return nilnul.num.real.bi_.add.cumula._CumulateX.Cumulate(seq);
		}

	}

}
