using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod.scaleds.sum.op_.unary_
{
	static public class _NegateX
	{
		static public Sum Op(Sum x) {
			return new Sum(
				x.scaleds.Select(s=>s.negate() )
			);
		}
	}
}
