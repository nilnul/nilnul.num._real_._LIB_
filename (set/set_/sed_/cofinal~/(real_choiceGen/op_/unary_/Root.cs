using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op
{
	public class Root1
	{
		static public double _Eval(double x_real_positive, int root_positive) {
			return Math.Pow(x_real_positive, 1.0 / root_positive);
		}


	}
}
