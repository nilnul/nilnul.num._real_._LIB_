using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod.scaleds.sum.op_.binary_
{
	static public class _AddX
	{
		static public Sum Op(Sum x, Sum y) {
			return new Sum(x.scaleds.Concat(y.scaleds));
		}
	}
}
