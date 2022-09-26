using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	[Obsolete(nameof(real.be.En4))]
	public class En<TBe>
		: nilnul.obj.be.En2<nilnul.num.RealI, TBe>
		where TBe : num.real.BeI, new()
	{
		public En(num.RealI val) : base(val)
		{
		}
	}
}
