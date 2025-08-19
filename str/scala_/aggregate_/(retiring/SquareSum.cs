using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.op
{
	[Obsolete(nameof(nilnul.num.real.accumulate_.SquareSum))]
	public class SquareSum
	{
		static public double Eval(IEnumerable<double> x) {
			return x.Select(a => num.real.op.Square.Eval(a)).Sum();
		}
	}
}
