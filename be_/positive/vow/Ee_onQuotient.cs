using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.positive.vow
{
	public class Ee_onQuotient : nilnul.num.real.vow.ee_.VowDefault_onQuotient<positive.Vow_onQuotient>
	{
		public Ee_onQuotient(num.RealI_onQuotient val) : base(val)
		{
		}

		public Ee_onQuotient(nilnul.num.quotient_.DenomNonnil quotient) : base(
			new nilnul.num.real_.Quotient_denomNonnil(quotient)
		)
		{

		}
		public Ee_onQuotient(nilnul.num.quotient_.DenomNonnilI quotient) : base(
					new nilnul.num.real_.Quotient_denomNonnil(quotient)
		)
		{

		}
		public Ee_onQuotient(nilnul.num.real_.Quotient_denomNonnil quotient) : base(
					(quotient)
		)
		{

		}
	}
}
