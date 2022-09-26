using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.geOne.vow
{
	public class En : nilnul.num.real.vow.En<geOne.Vow>
	{
		public En(num.RealI val) : base(val)
		{
		}

		public En(nilnul.num.QuotientI quotient):base(
			new nilnul.num.real_.Quotient(quotient)
		)
		{

		}
	}
}
