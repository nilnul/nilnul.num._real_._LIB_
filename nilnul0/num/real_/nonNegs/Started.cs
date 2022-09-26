using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach_.nonNegs
{
	public class Started
		: nilnul.objs.Started<NonNegI>
	{
		public Started(NonNegI head, IEnumerable<NonNegI> tail) : base(head, tail)
		{
		}
	}
}
