using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.be
{

	public class Vow4dbl
		:
		obj.str.be.Vow1<double>
		,
		str.Vow4dblI
	{
		public Vow4dbl(BeI1<IEnumerable<double>> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<IEnumerable<double>> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<IEnumerable<double>, bool> func) : base(func)
		{
		}
	}
}
