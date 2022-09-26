using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.str
{
	static public class ExtensionsX
	{
		static public Algebraic Variance(this IEnumerable<Algebraic> x) {
			return to_.scalar_.Variance.Singleton.to(x);
		}

	}
}
