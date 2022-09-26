using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num._real.cauchy.vow
{
	public class En<TVow> : nilnul.obj.vow.En<C, TVow>
		where TVow : nilnul.num._real.cauchy.VowI, new()
	{
		public En(C val) : base(val)
		{
		}
	}
}
