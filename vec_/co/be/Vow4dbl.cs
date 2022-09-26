using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.co.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			(double, double)
		>
		,
		co.Vow4dblI
	{
		public Vow4dbl(BeI1<(double, double)> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<(double, double)> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<(double, double), bool> func) : base(func)
		{
		}
	}
}
