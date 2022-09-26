using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;
using N = nilnul.Num1;
using Q = nilnul.num.Quotient1;
using R = nilnul.num.RealI;//.R;//.RealI;

namespace nilnul.num.real.op_.unary_
{
	/// <summary>
	/// an extension of Poly; the index can be negative.when the index is negative, the radic cannot be nil.
	/// </summary>
	/// <remarks>
	///		the index is integer. INteger 
	/// </remarks>
	static public class _IndexX
	{

		static public R RetRealI(R a, BigInteger i)
		{
			if (i < 0)
			{

				return nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(
					_PolyX.RealI(a, new nilnul.num_.Positive1(-i))
				);
			}
			return _PolyX.RealI_baseUnsureQuotient(a,
				new N(
				i
				)
			);
		}

		static public Real RetReal(R a, BigInteger i) {
			return new Real(RetRealI(a,i));
		}

		public static Real RetReal_assumeIndexNeg(nilnul.num.real_.Quotient a, BigInteger i)
		{

			return nilnul.num.quotient_.nonnil._IndexX.RetQuotient_assumeIndexNeg(a, i);


		}

		public static Real RetReal_assumeIndexNeg(nilnul.num.Quotient1 a, BigInteger i)
		{

			return nilnul.num.quotient_.nonnil._IndexX.RetQuotient_assumeIndexNeg(a, i);


		}
		public static Real RetReal_assumeIndexNat(nilnul.num.Quotient1 a, BigInteger i)
		{

			return nilnul.num.quotient.op_.unary_._PolyX.AssumeIndexNat(a, i);


		}

		public static R RetRealI(nilnul.num.Quotient1 a, BigInteger i)
		{
			if (i < 0)
			{
				return RetReal_assumeIndexNeg(a, i);

			}
			return RetReal_assumeIndexNat(a, i);

		}
		public static R RetRealI(nilnul.num.real_.Quotient a, BigInteger i)
		{
			return RetRealI(a.boxed, i);

		}

	}
}
