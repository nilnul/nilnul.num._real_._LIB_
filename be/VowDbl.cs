using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	public class VowDbl
		:
		nilnul.obj.be.Vow4<double>
		,
		real.VowOfDoubleI

	{
		public VowDbl(BeI1<double> be) : base(be)
		{
		}

		public VowDbl(Predicate<double> predicate) : base(predicate)
		{
		}

		public VowDbl(Func<double, bool> func) : base(func)
		{
		}
	}
}
