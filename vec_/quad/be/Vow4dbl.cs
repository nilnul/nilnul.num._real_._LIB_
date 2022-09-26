using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.quad.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			(double, double, double,double)
		>
		,
		quad.Vow4dblI
	{
		public Vow4dbl(BeI1<(double, double, double,double)> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<(double, double, double,double)> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<(double, double, double,double), bool> func) : base(func)
		{
		}
	}
}
