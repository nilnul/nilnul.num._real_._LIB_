using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.matrix_.square_.secondary
{
	static public class _DeterminantX
	{
		static public Algebraic Determinant(
			Algebraic a, Algebraic b
			,
			Algebraic c, Algebraic d
		) {
			return a * d - b * c;
		}
	}
}
