using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.be
{
	public class InferedEq
	{
		static public bool Eval(num.RealI x, num.RealI y) {
			if (x is num.real_.Quotient && y is num.real_.Quotient)
			{
				return (x as num.real_.Quotient) == (y as num.real_.Quotient);
			}
			else
			{
				//todo: if a cauchy of x: (a), a cauchy of y: (b), a and b is confluent.


				throw new NotImplementedException();

			}
		}
	}
}
