using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	public class En4
		: nilnul.obj.be.En4<nilnul.num.RealI>

	{
		public En4(RealI obj, BeI1<RealI> be) : base(obj, be)
		{
		}

		public En4(RealI obj, Predicate<RealI> predicate) : base(obj, predicate)
		{
		}

		public En4(RealI obj, Func<RealI, bool> predicate) : base(obj, predicate)
		{
		}
	}
}
