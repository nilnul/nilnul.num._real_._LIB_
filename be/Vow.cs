using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	public class Vow1
		: nilnul.obj.be.Vow4<nilnul.num.RealI>
		,
		nilnul.num.real.VowI2

	{
		public Vow1(BeI1<RealI> be) : base(be)
		{
		}

		public Vow1(Predicate<RealI> predicate) : base(predicate)
		{
		}

		public Vow1(Func<RealI, bool> func) : base(func)
		{
		}
	}

}
