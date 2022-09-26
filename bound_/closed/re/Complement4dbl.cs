using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.re
{
	public class Complement4dbl
		:
	nilnul.obj.re.Complement<
		ClosedDbl
	>
		,
		closed.Re4dblI
	{
		public Complement4dbl(obj.ReI<ClosedDbl> re) : base(re)
		{
		}
	}
}
