using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient_.nonnil.op_.unary_
{
	static public class _InverseX1
	{
		static public nilnul.num.real_.Quotient _Op(nilnul.num.real_.Quotient q) {
			return new Quotient(
				1/q.boxed
			);
		}
		static public nilnul.num.real_.Quotient Quotient(nilnul.num.real_.quotient_.NonnilI1 q) {
			return _Op( q.quotient);
		}

		static public nilnul.num.real_.quotient_.Nonnil1 Op(nilnul.num.real_.quotient_.NonnilI1 q) {
			return new nilnul.num.real_.quotient_.Nonnil1( Quotient( q));
		}



	}
}
