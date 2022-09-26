using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.duo_.divisible.bind_
{
	static public class _DivX
	{

		static public A Approach(
			A x
			,
			approach_.NonnilI y

		)
		{
			return new _div.Of(x, y);
		}

		static public A Approach(
			A x
			,
			A y_nonZero

		)
		{
			return Approach( x, new approach_.Nonnil(y_nonZero));
		}

		
	}
}
