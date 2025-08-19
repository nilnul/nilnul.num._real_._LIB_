using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.bi_
{
	static public class _MinusX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Minus_1equisize(
			this
			IEnumerable<double> x
			,
			IEnumerable<double> y
		) {
			return x.Zip(y, (a, b) => a - b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<Q4> _Minus_1equisize(
			this
			IEnumerable<Q4> x
			,
			IEnumerable<Q4> y
		) {
			return x.Zip(y, (a, b) => a - b);
		}


	}
}
