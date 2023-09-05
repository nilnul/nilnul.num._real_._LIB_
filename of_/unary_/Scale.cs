using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using nilnul.num.real_;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using Rq = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using nilnul.num.quotient_;

namespace nilnul.num.real.op_.unary_
{

	static public class _ScaleX
	{
		public static Real Op(Q0 scale, nilnul.num.Quotient1 arg)
		{
			return nilnul.num.quotient.op_.binary_.Multi1.Singleton.op(scale, arg);

		}

		public static Real Op(nilnul.num.QuotientI1 scale, nilnul.num.QuotientI1 arg)
		{
			return new Real( nilnul.num.quotient.op_.binary_.Multi1.Singleton.op(scale, arg) );

		}

		public static R Op_assumeNotQuotient(Q0 scale, R arg)
		{

			if (scale == 0)
			{
				return new nilnul.num.real_.Quotient();
			}

			if (scale == 1)
			{
				return arg;
			}


			return new _scale.ret_.ScaleNonnil(scale, arg);
			//throw new NotImplementedException();
		}


		public static R Op_assumeUnsureQuotient(nilnul.num.QuotientI1 scale, R arg)
		{

			if (scale.numerator == 0)
			{
				return new nilnul.num.real_.Quotient();
			}

			if (scale.numerator == scale.denominator1)
			{
				return arg;
			}


			return new _scale.ret_.ScaleNonnil(scale, arg);
			//throw new NotImplementedException();
		}


		public static R Op(Q0 scale, R arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Op(scale, arg.current.lower.mark);
			}

			return Op_assumeNotQuotient(scale, arg);
			//throw new NotImplementedException();
		}


		public static R Op(nilnul.num.QuotientI1 scale, R arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Op(scale, arg.current.lower.mark);
			}

			return Op_assumeUnsureQuotient(scale, arg);
			//throw new NotImplementedException();
		}

		static public R Op(this R arg, Q0 scale)
		{
			return Op(scale, arg);
			//throw new NotImplementedException();
		}


		public static R Op(int a, R b)
		{
			return Scale(new nilnul.num.Quotient1(a), b);
			//throw new NotImplementedException();
		}

		public static R Op(int a, Real b)
		{
			return Scale(new nilnul.num.Quotient1(a), b);
			//throw new NotImplementedException();
		}

		public static R Scale(Rq scale, R x)
		{
			return Op(scale.boxed, x);
		}

		static public R Halve(this R r)
		{

			return Op(Q0.CreateHalf(),r );

		}

		public static R Op(NumI1 b, Real a)
		{
			return Op(new Q0(b),a);
		}
		public static R Op(Num1 b, Real a)
		{
			return Op(new Q0(b),a);
		}

		public static R Op(DenomNonnil b, Real a)
		{
			return Op( num.Quotient1.CreateByDivide(b.numerator,b.denominator),a );
		}

	}
}
