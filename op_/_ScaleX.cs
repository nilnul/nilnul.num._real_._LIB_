using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using nilnul.num.real_;
using Q0 = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using Rq = nilnul.num.real_.Quotient_denomNonnil;
using R = nilnul.num.RealI_onQuotient;
using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using System.Numerics;

namespace nilnul.num.real.op_
{

	static public class _ScaleX
	{
		public static R Op(Q0 scale, nilnul.num.quotient_.DenomNonnil arg)
		{
			return (nilnul.num.real_.Quotient_denomNonnil)  scale*arg;
		}

		public static Real Op(nilnul.num.QuotientI1 scale, nilnul.num.QuotientI1 arg)
		{
			return new Real( nilnul.num.quotient.op_.binary_.Multi1.Singleton.op(scale, arg) );
		}
	
		public static R _Op_1asNonquotient(nilnul.num.quotient_.DenomNonnil scale, R arg)
		{

			if (scale.numerator == 0)
			{
				return new nilnul.num.real_.Quotient_denomNonnil();
			}

			if (scale.numerator == scale.denominator)
			{
				return arg;
			}


			return new _scale.ret_.ScaleNonnil(scale, arg);
			//throw new NotImplementedException();
		}

		public static R _Op_1asNonquotient(Q0 scale, Real_onQuotient arg)
		{

			if (scale == 0)
			{
				return new nilnul.num.real_.Quotient_denomNonnil();
			}

			if (scale == 1)
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
				return Op(scale, arg.current.begin);
			}

			return _Op_1asNonquotient(scale, arg);
			//throw new NotImplementedException();
		}
		public static R Op(quotient_.DenomNonnil scale, Real_onQuotient arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Op(scale, arg.current.begin);
			}

			return _Op_1asNonquotient(scale, arg);
			//throw new NotImplementedException();
		}


		public static R Op(nilnul.num.quotient_.DenomNonnilI scale, R arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Op(scale.ToImpl(), arg.current.begin);
			}

			return _Op_1asNonquotient(scale.ToImpl(), arg);
			//throw new NotImplementedException();
		}
		public static R Op(DenomNonnilI b, Real_onQuotient a)
		{
			return Op(b,(R) a );
		}

		static public R Op(this R arg, Q0 scale)
		{
			return Op(scale, arg);
			//throw new NotImplementedException();
		}


		public static R Op(int a, R b)
		{
			return Op(new nilnul.num.quotient_.DenomNonnil(a), b);
			//throw new NotImplementedException();
		}

		public static R Op(int a, Real_onQuotient b)
		{
			return Op(new nilnul.num.quotient_.DenomNonnil(a), b);
			//throw new NotImplementedException();
		}

		public static R Op(BigInteger a, R b)
		{
			return Op(new nilnul.num.quotient_.DenomNonnil(a), b);
			//throw new NotImplementedException();
		}

	
		public static R Op(BigInteger a, Real_onQuotient b)
		{
			return Op(new nilnul.num.quotient_.DenomNonnil(a), b);
			//throw new NotImplementedException();
		}

		public static R Op(Rq scale, R x)
		{
			return Op(scale.boxed, x);
		}

		static public R Halve(this R r)
		{

			return Op(Q0.Secondth,r );

		}

	
		public static R0 Op(NumI1 b, Real_onQuotient a)
		{
			return Op((b.toBigint()),a);

		}

		public static R0 Op(Num1 b, Real_onQuotient a)
		{
			return Op((b.en),a);

		}

	


	}
}
