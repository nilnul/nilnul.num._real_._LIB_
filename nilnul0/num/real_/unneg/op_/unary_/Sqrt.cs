using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real_.nonneg.op_.unary_
{
	static public class _SqrtX
	{
		static public R Real_assumePositive(nilnul.num.Quotient1 arg)
		{
			
			if (arg < 1)
			{
				return new _sqrt.ret_.ofQuotient_.PositiveLtOne(arg);
			}
			if (arg == 1)
			{
				return (nilnul.num.real_.Quotient)1;
			}
			return new _sqrt.ret_.ofQuotient_.GtOne(arg);
		}
		static public R Real_assumeNonneg(nilnul.num.Quotient1 arg)
		{
			if (arg == 0)
			{
				return (nilnul.num.real_.Quotient)0;
			};
			return Real_assumePositive(arg);
		}

		public static R RetRealI(uint v)
		{
			return Real_assumeNonneg(v);
		}

		static public R Real_assumeNonneg(nilnul.num.real_.Quotient arg)
		{

			return Real_assumeNonneg(arg.boxed);

		}


		static public R Real_assumeNonneg(int v)
		{
			return Real_assumeNonneg(new nilnul.num.real_.Quotient(v));
		}

		static public R Real_assumeNonneg(ulong arg)
		{

			return Real_assumeNonneg(new nilnul.num.Quotient1(arg));
		}
		static public Nonneg Nonneg_assumePositive(this nilnul.num.real_.Quotient nonneg)
		{
			return new Nonneg( Real_assumeNonneg(nonneg) );
		}

		public static RealI Real(num.real_.NonnegI arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Real_assumeNonneg(arg.current.lower.mark);
			}
			return new _sqrt.Ret(arg);
		}
		public static Nonneg Nonneg(num.real_.NonnegI arg)
		{
			return new Nonneg(
				Real(arg)
			);
		}

		public static RealI Real(PositiveI arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Real_assumePositive(arg.current.lower.mark);
			}
			return new _sqrt.Ret(arg);
		}

		public static Positive Positive(PositiveI arg)
		{
			return new Positive(
				Real(arg)
			);
		}
	}
	public class Sqrt
		: nilnul.num.real_.nonneg.op_.UnaryI
	{


		///Unicode Character 'SQUARE ROOT' (U+221A)  
		/// 
		public const char CHAR = '\u221a';

		public NonnegI op(NonnegI arg)
		{
			
			return _SqrtX.Nonneg(arg);
		}

		public NonnegI op(R arg)
		{
			return op(new nilnul.num.real_.Nonneg(arg));
		}
		public NonnegI op(int arg)
		{
			return op(new nilnul.num.real_.Nonneg(arg));
		}



		static public Sqrt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sqrt>.Instance;
			}
		}



	}
}
