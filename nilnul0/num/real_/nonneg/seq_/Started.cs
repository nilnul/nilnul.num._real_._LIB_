using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonNegs
{
	public class Started
		: nilnul.objs.Started<nilnul.num.real_.NonnegI>
	{
		public Started(NonnegI head, IEnumerable<NonnegI> tail) : base(head, tail)
		{

		}
	}
}
