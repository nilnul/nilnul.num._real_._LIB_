using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonnil.str
{
	public class HarmonicSum
	{
		static public double Eval(IEnumerable<double> x_allNonZero) {
			if (x_allNonZero.Count()==0)
			{
				return 0;
			}
			else
			{
				return num.real_.nonnil.op_.unary_._InverseX.Op(
						x_allNonZero.First()
					)
					+ 
					Eval(
						x_allNonZero.Skip(1)
					);
			}
		}
	}
}
