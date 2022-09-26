using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.geNegOne.vow
{
	public class Ee : nilnul.num.real.vow.ee_.VowDefault<geNegOne.Vow>
	{
		public Ee(num.RealI val) : base(val)
		{
		}

		public Ee(nilnul.num.QuotientI1 quotient):base(
			new nilnul.num.real_.Quotient(quotient)
		)
		{

		}
	}
}
