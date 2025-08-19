using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.op_.unary_
{
	static public  class _SquareX
	{
		static public A Approach(A x) {
			return new _square.Of(x);
		}
	}
}
