using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.re_
{
	static public class _OrthicX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Re(
			IEnumerable<Q4> a
			,
			IEnumerable<Q4> b
		) {
			return nilnul.num.real.vec.co._InnerProductX._InnerProduct_1equisize(a, b) == 0;
		}
	}
}
