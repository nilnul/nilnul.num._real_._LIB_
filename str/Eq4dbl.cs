using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str
{
	public class Eq4dbl
		: nilnul.obj.str.Eq<double>
		,
		IEqualityComparer<
			IEnumerable<double>
		>
	{


	}
}
