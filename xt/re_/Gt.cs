using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.re_
{
	static public class _GtX
	{
		static public bool Gt(nilnul.num.real.ExtI x, nilnul.num.real.ExtI y) {
			return _LtX.Lt(y, x);
		}
	}
}
