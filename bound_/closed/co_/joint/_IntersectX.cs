using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.co_.joint
{
	static public class _IntersectX
	{
		static public bound_.ClosedDbl _Intersect_01joint(ClosedDbl a, ClosedDbl b) {
			return new ClosedDbl(
				Math.Max(a.avowed.lower.mark, b.avowed.lower.mark)
				,
				Math.Min(a.avowed.upper.mark, b.avowed.upper.mark)

			);
		}
	}
}
