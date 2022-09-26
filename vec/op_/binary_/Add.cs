using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.op_.binary_
{
	static public class _AddX
	{
		static public IEnumerable<double> _Add_assumeEquisize(
			this
			IEnumerable<double> x
			,
			IEnumerable<double> y
		) {
			return x.Zip(y, (a, b) => a + b);
		}
	}
}
