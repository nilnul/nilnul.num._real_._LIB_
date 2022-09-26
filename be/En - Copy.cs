using nilnul.obj.be.vow_.xpN_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	public class EnDbl
		: nilnul.obj.be.En3<double, nilnul.num.real.IBeOfDouble>
	{
		public EnDbl(double val, Fail<double, IBeOfDouble> vow) : base(val, vow)
		{
		}

		public EnDbl(double obj, IBeOfDouble be) : base(obj, be)
		{
		}
	}
}
