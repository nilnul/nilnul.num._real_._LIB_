using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.upper.be_
{
	static public class _HasX
	{
		static public bool Has(_bound.UpperDbl upper, double x) {
			return upper.openFalseCloseTrue ? x <= upper.mark : x < upper.mark;
		}
	}
}
