using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border_
{
	static public class _LowerX
	{
		static public bool Contain(num.real.ext.BorderI border, num.real.ExtI real) {
			return border.openFalseCloseTrue ? num.real.ext.re_._LeX.Le(border.mark, real) : num.real.ext.re_._LtX.Lt(border.mark, real);
		}
		static public bool Contain(num.real.ext.BorderI border, num.RealI real) {
			return Contain(border, new num.real.ext_.Bare(real));
		}


	}
}
