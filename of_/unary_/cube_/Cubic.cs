using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.doubl.op
{
	public class Cubic
	{
		static public double Eval(double x) {
			return Square.Eval(x)*x;
		}
	}
}
