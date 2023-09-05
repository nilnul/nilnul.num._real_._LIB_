using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.reals
{
	public class Started
		: nilnul.objs.Started<nilnul.num.RealI>
	{
		public Started(RealI head, IEnumerable<RealI> tail) : base(head, tail)
		{
		}
	}
}
