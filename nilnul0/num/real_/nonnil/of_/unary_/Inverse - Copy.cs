using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;
using nilnul.num._real.limit.sow;
using R = nilnul.num.RealI3;


namespace nilnul.num.real_.nonnil.op_.unary_
{
	[Obsolete()]
	static public class _InverseX
	{
		static public double Op(double x_nonZero)
		{
			return 1 / x_nonZero;
		}


		static public NonnilI Op(nilnul.num.real_.quotient_.NonnilI quotient) {
			return new Nonnil(
				nilnul.num.real_.quotient_.nonnil.op_.unary_._InverseX.Quotient(quotient)
			);
		}
		static public NonnilI Op(nilnul.num.real_.quotient_.Nonnil quotient) {
			return Op((nilnul.num.real_.quotient_.NonnilI)(quotient));
		}


		static public NonnilI Op(nilnul.num.real_.Quotient1 quotient) {
			return Op(new nilnul.num.real_.quotient_.Nonnil(quotient));
		}

		static public NonnilI Op(BigInteger b)
		{
			return Op( new nilnul.num.real_.Quotient1(b)  );
		}


		static public NonnilI Op(NonnilI arg)
		{
			return new _inverse.Ret(arg);

		}

		static public NonnilI Op(R arg)
		{
			return Op( new Nonnil(arg) );

		}
	}
}
