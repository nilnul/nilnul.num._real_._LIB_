using System.Numerics;
namespace nilnul.num.real.op_.unary_
{
	static public class _SquareX
	{
		static public nilnul.num.real_.Quotient Op(BigInteger r)
		{
			return nilnul.num.integer.op_.unary_.Square.Singleton.op(r);
		}
		static public nilnul.num.real_.Quotient Op(nilnul.num.Quotient1 r)
		{
			return nilnul.num.quotient.op_.unary_._SquareX.Square(r);
		}

		static public nilnul.num.real_.Quotient Op(nilnul.num.real_.Quotient r)
		{
			return nilnul.num.quotient.op_.unary_._SquareX.Square(r);
		}
		static public nilnul.num.RealI Op_assumeNotQuotient(nilnul.num.real_.PositiveI r)
		{
			return new op_.unary_._square.Ret(
				r
			);

		}
		static public nilnul.num.RealI Op_assumeNotQuotient(nilnul.num.RealI r)
		{
			return new op_.unary_._square.Ret(
				r
			);

		}
		static public nilnul.num.RealI Op(nilnul.num.RealI r)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(r))
			{
				return Op(r.current.lower.mark);
			};
			return Op_assumeNotQuotient(r);

		}


	}
}