using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num._real.cauchy.op_.unary_
{
	static public class _SquareX
	{
		static public C Cauchy(C x) {
			return new _square.Of(x);
		}
	}
}
