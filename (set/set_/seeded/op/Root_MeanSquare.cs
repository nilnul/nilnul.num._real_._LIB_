using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.seed.op
{
	public class Root_MeanSquare
	{
		public static double Eval(IEnumerable<double> x) {
			return Math.Sqrt( num.real.accumulate_.SquareSum.Eval(x) / x.Count());
		}
	}
}
