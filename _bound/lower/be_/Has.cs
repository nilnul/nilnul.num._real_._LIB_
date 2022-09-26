using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lower.be_
{
	static public class _HasX
	{
		static public bool Has(_bound.LowerDbl lower, double x) {
			return lower.openFalseCloseTrue ? x >= lower.mark : x > lower.mark;
		}
	}
}
