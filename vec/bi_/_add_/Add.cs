using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.of_.binary_
{
	static public class _AddX
	{
		[Obsolete(nameof(vec.bi_._AddX))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Add_1equisize(
			this
			IEnumerable<double> x
			,
			IEnumerable<double> y
		) {
			return x.Zip(y, (a, b) => a + b);
		}
	}
}
