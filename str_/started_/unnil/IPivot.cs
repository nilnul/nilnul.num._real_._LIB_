using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str_.started_.unnil
{
	static public class _PivotX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int _Pivot_0unnil(IEnumerable<double> unnil) {
			return unnil.Select(
				(v, i) => (v, i)
			).SkipWhile(
				t=>t.v ==0
			).First().i;
		}
	}
	internal class IPivot
	{
	}
}
