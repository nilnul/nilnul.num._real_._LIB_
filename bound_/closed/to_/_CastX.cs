using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.to_
{
	static public class _CastX
	{
		static public bound_.Open4dbl Inner(this real.bound_.ClosedDbl x ) {
			return new bound_.Open4dbl(x.avowed.lower.mark, x.avowed.upper.mark);
		}
		static public bound_.ClosedDbl Inside(this real.bound_.ClosedDbl x ) {
			return x;
		}
		static public bound_.Clopen4dbl ToClopen(this real.bound_.ClosedDbl x ) {
			return new bound_.Clopen4dbl(x.avowed.lower.mark, x.avowed.upper.mark);
		}

		static public bound_.OpenClose4Dbl ToOpenClose(this real.bound_.ClosedDbl x ) {
			return new bound_.OpenClose4Dbl(x.avowed.lower.mark, x.avowed.upper.mark);
		}


	}
}
