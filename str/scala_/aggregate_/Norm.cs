using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.accumulate_
{
	static public class _NormX
	{
		static public double Accumulate(IEnumerable<double> x) {
			return
				Math.Sqrt(SquareSum.Eval(x) );
		}


	}
}
