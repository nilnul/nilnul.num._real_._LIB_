using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.op
{
	public class Product
	{
		static public double Eval(IEnumerable<double> x) {
			if (x.Count()==0)
			{
				return 1;
			}
			else
			{
				return x.First() * Eval(x.Skip(1));
			}
		}
	}
}
