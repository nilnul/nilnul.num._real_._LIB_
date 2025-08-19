using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac.matrix_.square_.secondary
{
	static public class _DeterminantX
	{
		static public Frac Determinant(
			Frac a, Frac b
			,
			Frac c, Frac d
		) {
			return a * d - b * c;
		}
	}
}
