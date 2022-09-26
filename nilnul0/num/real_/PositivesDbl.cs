using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_
{
	public class PositiveDblS : nilnul.Objs_arr<real_.PositiveDbl>
	{
		public PositiveDblS(PositiveDbl[] val) : base(val)
		{
		}

		public PositiveDblS(IEnumerable<PositiveDbl> tail) : base(tail)
		{
		}
	}
}
