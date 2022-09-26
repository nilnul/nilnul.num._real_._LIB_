using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op_
{
	static public  class _CubicX
	{
		static public double Cubic(this double x) {
			return nilnul.num.real.double_.SquareX.Square(x) * x;
		}
	}
}
