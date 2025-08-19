using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;
using R = nilnul.num.RealI;


namespace nilnul.num.real_.nonnil.op_
{
	static public class _InverseX
	{
		static public double Op(double x_nonZero)
		{
			return 1 / x_nonZero;
		}

		static public NonnilI Op(nilnul.num.real_.quotient_.NonnilI1 quotient) {
			return new Nonnil(
				nilnul.num.real_.quotient_.nonnil.op_.unary_._InverseX1.Quotient(quotient)
			);
		}
		static public NonnilI Op(nilnul.num.real_.quotient_.Nonnil1 quotient) {
			return Op((nilnul.num.real_.quotient_.NonnilI1)(quotient));
		}


		static public NonnilI Op(nilnul.num.real_.Quotient quotient) {
			return Op(new nilnul.num.real_.quotient_.Nonnil1(quotient));
		}

		static public NonnilI Op(BigInteger b)
		{
			return Op( new nilnul.num.real_.Quotient(b)  );
		}

		

		static public num.RealI_onQuotient Op(num.real.be_.nonnil.vow.Ee_onQuotient arg)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(arg.eeByRef))
			{
				return new nilnul.num.real_.Quotient_denomNonnil( 
					nilnul.num.quotient_.nonnil.op_.unary_._InverseX.Op(
					arg.eeByRef.current.begin
					)
				);
			}

			return new _inverse.Ret(  arg);
		}

		static public num.RealI_onQuotient Op(num.real_.NonnilI_onQuotient arg)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return new nilnul.num.real_.Quotient_denomNonnil( 
					nilnul.num.quotient_.nonnil.op_.unary_._InverseX.Op(
					arg.current.begin
					)
				);
			}

			return new _inverse.Ret(  arg);
		}
		static public num.RealI_onQuotient Op(num.real_.Nonnil_onQuotient arg)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return new nilnul.num.real_.Quotient_denomNonnil( 
					nilnul.num.quotient_.nonnil.op_.unary_._InverseX.Op(
					arg.current.begin
					)
				);
			}

			return new _inverse.Ret(  arg);
		}


		static public R0 Op(RealI_onQuotient arg)
		{
			return Op( new Nonnil_onQuotient(arg) );

		}
	}
}
