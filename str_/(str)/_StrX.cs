using System.Collections.Generic;

namespace nilnul.num.real
{
	static public class _StrX
	{
		static public nilnul.num.RealI Sum(this IEnumerable<nilnul.num.RealI> seq) {
			return nilnul.num.real.accumulate_._SumX.Sum_bisect(seq);
		}

	}

}
