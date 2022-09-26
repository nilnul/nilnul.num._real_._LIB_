using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	static public class _StrX
	{
		static public nilnul.num.RealI Sum(this IEnumerable<nilnul.num.RealI> seq) {
			return nilnul.num.real.accumulate_._SumX.Sum_bisect(seq);
		}
	}
	public partial interface StrI
		: nilnul.obj.StrI1<nilnul.num.RealI>
	{
	}

}
