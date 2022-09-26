using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str.op_.unary_
{
	static public class _ScaleX
	{
		static public IEnumerable<double> Scale(this IEnumerable<double> a, double scale) {
			return  a.Select(x=> x*scale);
		}

	}
}
