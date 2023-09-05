using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.seed.op
{
	/// <summary>
	/// note: 1,1,2,... so this is better treated as a str rather than a set.
	/// </summary>
	public class Mean
	{
		static public double _Eval(params double[] _seed) {

			return _seed.Average();

		}
	}
}
