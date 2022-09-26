using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.absLeOne.vow
{
	public class Ee : nilnul.num.real.vow.En<absLeOne.Vow>
	{
		public Ee(num.RealI val) : base(val)
		{
		}

		public Ee(nilnul.num.QuotientI quotient):base(
			new nilnul.num.real_.Quotient(quotient)
		)
		{

		}
	}
}
