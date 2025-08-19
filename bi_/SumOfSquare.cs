using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary_
{
	static public class _SumOfSquareX
	{
		static public double SumOfSquare(double x, double y) {
			return nilnul.num.real.op_.Square.Singleton.op(x)
				+ nilnul.num.real.op_.Square.Singleton.op(y);
		}
	}
}
