using System.Numerics;
using N = nilnul.Num1;
using R = nilnul.num.RealI_onQuotient;//.R;//.RealI;

namespace nilnul.num.real.op_
{
	/// <summary>
	/// an extension of Poly; the index can be negative.when the index is negative, the radic cannot be nil.
	/// </summary>
	/// <remarks>
	///		the index is integer. INteger 
	/// </remarks>
	/// alias:
	///		indic
	static public class _IndicandX
	{

		static public R RealI(R a, BigInteger i)
		{
			if (i < 0)
			{

				return nilnul.num.real_.nonnil.op_._InverseX.Op(
					_PonentX.AsInterface(a, new nilnul.num_.Positive1(-i))
				);
			}
			return _PonentX._AsInterface_0asNonquotient(a,
				new N(
				i
				)
			);
		}

		static public Real_onQuotient RetReal(R a, BigInteger i) {
			return  Real_onQuotient.Of(RealI(a,i));
		}

		public static Real_onQuotient _Real_1neg(nilnul.num.real_.Quotient_denomNonnil a, BigInteger i)
		{

			return nilnul.num.quotient_.nonnil.op_._IndicandX._Quotient_1neg(a.boxed, i);


		}

		public static Real RetReal_assumeIndexNeg(nilnul.num.Quotient1 a, BigInteger i)
		{

			return nilnul.num.quotient_.nonnil._IndexX.RetQuotient_assumeIndexNeg(a, i);


		}
		public static Real_onQuotient _Real_1natural(nilnul.num.quotient_.DenomNonnil a, BigInteger i)
		{

			return nilnul.num.quotient.op_._PonentX._Quotient_1natural(a, i);

		}

		public static Real RetReal_assumeIndexNat(nilnul.num.Quotient1 a, BigInteger i)
		{

			return nilnul.num.quotient.op_.unary_._PolyX.AssumeIndexNat(a, i);

		}

		public static RealI RetRealI(nilnul.num.Quotient1 a, BigInteger i)
		{
			if (i < 0)
			{
				return RetReal_assumeIndexNeg(a, i);

			}
			return RetReal_assumeIndexNat(a, i);

		}

		public static Real_onQuotient RealI(nilnul.num.quotient_.DenomNonnil a, BigInteger i)
		{
			if (i < 0)
			{
				return _Real_1neg(a, i);

			}
			return _Real_1natural(a, i);

		}

		public static RealI RetRealI(nilnul.num.real_.Quotient a, BigInteger i)
		{
			return RetRealI(a.boxed, i);
		}

		public static R0 RetRealI(nilnul.num.real_.Quotient_denomNonnil a, BigInteger i)
		{
			return RealI(a.boxed, i);

		}


	}
}
