using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound.be
{
	public class En
		: nilnul.obj.be.En4<num.real.BoundI>

	{
		public En(BoundI obj, BeI1<BoundI> be) : base(obj, be)
		{
		}

		public En(BoundI obj, Predicate<BoundI> predicate) : base(obj, predicate)
		{
		}

		public En(BoundI obj, Func<BoundI, bool> predicate) : base(obj, predicate)
		{
		}
	}
}
