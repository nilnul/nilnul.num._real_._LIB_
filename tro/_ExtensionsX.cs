using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.tro
{
	static public class _ExtensionsX
	{
		static public (double, double, double) Divide(this (double,double,double)x, double y) {
			return (x.Item1/y,x.Item2/y,x.Item3/y);
		}
		static public  double Distance(this (double,double,double)x) {
			return Math.Sqrt(x.Variance());
		}
		static public  double Variance(this (double,double,double)x) {
			return real.vec_.tro.Variance.Singleton.to(x);
		}


	}
}
