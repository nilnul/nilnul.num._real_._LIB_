using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	public class Vow4float
		:
		nilnul.obj.be.Vow4<float>
		,
		real.Vow4floatI

	{
		public Vow4float(BeI1<float> be) : base(be)
		{
		}

		public Vow4float(Predicate<float> predicate) : base(predicate)
		{
		}

		public Vow4float(Func<float, bool> func) : base(func)
		{
		}
	}
}
