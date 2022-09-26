using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qr = nilnul.num._real.approach.generator.cofinal_.Quotient;

namespace nilnul.num._real.approach.generator.cofinal_.quotient.duo.op
{
	[Obsolete()]
	public class Multi
	{
		static public Qr Eval(Qr a, Qr b) {
			return new Qr(
				a.q*b.q	
			);
		}
	}
}
