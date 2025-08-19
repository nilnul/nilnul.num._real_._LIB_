using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.gtOne.vow
{
	public class Ee : nilnul.num.real.vow.ee_.VowDefault_onQuotient<gtOne.Vow_onQuotient>
	{
		public Ee(num.RealI_onQuotient val) : base(val)
		{
		}

		public Ee(nilnul.num.quotient_.DenomNonnilI quotient):base(
			new nilnul.num.real_.Quotient_denomNonnil(quotient)
		)
		{

		}
	}
}
