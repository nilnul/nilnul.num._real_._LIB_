using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic
{
	static public class PowX
	{
		static public Pow_indexPositive AsPow(this nilnul.num.real.expr_.VarI var) {
			return new Pow_indexPositive(var);
		}
	}
}
