using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient_.nonnil.op_.unary_
{
	[Obsolete()]
	static public class _InverseX
	{
		static public nilnul.num.real_.Quotient1 _Op(nilnul.num.real_.Quotient1 q) {
			return new Quotient1(
				1/q.quotient
			);
		}
		static public nilnul.num.real_.Quotient1 Quotient(nilnul.num.real_.quotient_.NonnilI q) {
			return _Op( q.nonnil);
		}

		static public nilnul.num.real_.quotient_.Nonnil Op(nilnul.num.real_.quotient_.NonnilI q) {
			return new nilnul.num.real_.quotient_.Nonnil( Quotient( q));
		}



	}
}
