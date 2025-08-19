using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.duo
{
	static public class _ContainX
	{
		static public bool Contains(this Duo duo, ExtI x ) {
			return border.comparer_.Lower.Decider.Contains(duo.lower, x)

				&&
				border.comparer_.Upper.Decider.Contains(duo.upper, x);
			
		}
	}
}
