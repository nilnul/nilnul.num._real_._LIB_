using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.re_
{
	static public class _GeX
	{
		static public bool Ge(nilnul.num.real.ExtI x, nilnul.num.real.ExtI y) {
			return _LeX.Le(y, x);
		}
	}
}
