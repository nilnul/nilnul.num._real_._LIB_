using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieeeF.be
{
	public class En
		:
		nilnul.obj.be.En<float, BeI>
	{
		public En(float val, BeI be) : base(val, be)
		{
		}
	}

	public class En_beDefaultable<T> : nilnul.obj.be.En_beDefaultable<float, T>
		where T : BeI, new()

	{
		public En_beDefaultable(float val) : base(val)
		{
		}
	}
}
