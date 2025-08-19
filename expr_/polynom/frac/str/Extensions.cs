using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac.str
{
	static public class ExtensionsX
	{
		static public Frac Variance(this IEnumerable<Frac> x) {
			return to_.scalar_.Variance.Singleton.to(x);
		}

	}
}
