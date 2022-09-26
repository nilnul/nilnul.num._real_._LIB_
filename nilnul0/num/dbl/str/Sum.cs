using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.ieee.str
{
	static public class SumX
	{
		static public double Sum(params double[] x) {
			return Sum(x as IEnumerable<double>);
		}
		static public double Sum(IEnumerable<double> x)
		{
			return x.Sum();
		}
	}
}
