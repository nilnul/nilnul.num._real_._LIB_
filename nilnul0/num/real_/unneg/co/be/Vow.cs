using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.co.be
{
	public class Vow
		: nilnul.obj.be.Vow4<nonneg.CoDbl>
	{
		public Vow(BeI1<CoDbl> be) : base(be)
		{
		}

		public Vow(Predicate<CoDbl> predicate) : base(predicate)
		{
		}

		public Vow(Func<CoDbl, bool> func) : base(func)
		{
		}
	}
}
