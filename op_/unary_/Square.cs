using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI;
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
	public class Square
		: UnaryI
	{

		public R op(R arg)
		{

			return _SquareX.Op(arg);
		}



		public double op(double x)
		{
			return x * x;
		}


		public decimal op(decimal x)
		{
			return x * x;
		}

		static public Square Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}
		static private Lazy<Square> _Lazy = new Lazy<Square>();

		static public Square Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Square>.Instance;
			}
		}

	}
}