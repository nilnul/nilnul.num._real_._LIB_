using System.Numerics;
namespace nilnul.num.real.op_
{
	static public class _SquareX
	{
		static public nilnul.num.real_.Quotient Op(BigInteger r)
		{
			return nilnul.num.integer.op_.unary_.Square.Singleton.op(r);
		}
		static public nilnul.num.real_.Quotient_denomNonnil Op(nilnul.num.quotient_.DenomNonnil r)
		{
			return nilnul.num.quotient.op_._SquareX.Square(r);
		}

		static public nilnul.num.real_.Quotient_denomNonnil Op(nilnul.num.real_.Quotient_denomNonnil r)
		{
			return nilnul.num.quotient.op_._SquareX.Square(r);
		}
	
		static public nilnul.num.RealI_onQuotient _Op_0maybeNonrational(nilnul.num.RealI_onQuotient r)
		{
			return new op_._square.Ret(
				r
			);
		}

	

		static public nilnul.num.RealI_onQuotient Op(nilnul.num.RealI_onQuotient r)
		{
			return Op(in r);
	

		}
		static public nilnul.num.RealI_onQuotient Op(in nilnul.num.RealI_onQuotient r)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(r))
			{
				return Op(r.current.begin);
			};
			return _Op_0maybeNonrational(r);

		}




	}
}