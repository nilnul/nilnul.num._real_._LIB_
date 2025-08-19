using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real_.nonneg.op_
{
	static public class _SqrtX
	{
		static public R Real_assumePositive(nilnul.num.quotient_.DenomNonnil arg)
		{
			
			if (arg < 1)
			{
				return new _sqrt.ret_.ofQuotient_.PositiveLtOne(arg);
			}
			if (arg == 1)
			{
				return (nilnul.num.real_.Quotient_denomNonnil)1;
			}
			return new _sqrt.ret_.ofQuotient_.GtOne(arg);
		}
		static public R Real_assumeNonneg(nilnul.num.quotient_.DenomNonnil arg)
		{
			if (arg == 0)
			{
				return (nilnul.num.real_.Quotient_denomNonnil)0;
			};
			return Real_assumePositive(arg);
		}

		public static R RetRealI(uint v)
		{
			return Real_assumeNonneg(v);
		}

		static public R Real_assumeNonneg(nilnul.num.real_.Quotient_denomNonnil arg)
		{

			return Real_assumeNonneg(arg.boxed);

		}


		static public R Real_assumeNonneg(int v)
		{
			return Real_assumeNonneg(new nilnul.num.real_.Quotient_denomNonnil(v));
		}

		static public R Real_assumeNonneg(ulong arg)
		{

			return Real_assumeNonneg(new nilnul.num.quotient_.DenomNonnil(arg));
		}
		static public Nonneg_onQuotient Nonneg_assumePositive(this nilnul.num.real_.Quotient_denomNonnil nonneg)
		{
			return new Nonneg_onQuotient( Real_assumeNonneg(nonneg) );
		}

		public static R Real(num.real_.NonnegI_onQuotient arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Real_assumeNonneg(arg.current.begin);
			}
			return new _sqrt.Ret(arg);
		}
		public static Nonneg_onQuotient Nonneg(num.real_.NonnegI_onQuotient arg)
		{
			return new Nonneg_onQuotient(
				Real(arg)
			);
		}

		public static R Real(num.real_.PositiveI_onQuotient arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return Real_assumePositive(arg.current.begin);
			}
			return new _sqrt.Ret(arg);
		}

		public static Positive_onQuotient Positive(num.real_.PositiveI_onQuotient arg)
		{
			return new Positive_onQuotient(
				Real(arg)
			);
		}
	}
	public class Sqrt
		: nilnul.num.real_.nonneg.OpI1
	{


		///Unicode Character 'SQUARE ROOT' (U+221A)  
		/// 
		public const char CHAR = '\u221a';

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Nonneg_onQuotient op4impl(in NonnegI_onQuotient arg)
		{
			
			return _SqrtX.Nonneg(arg);
		}

		public Nonneg_onQuotient op4impl(R arg)
		{
			return op4impl(new nilnul.num.real_.Nonneg_onQuotient(arg));
		}
		public NonnegI_onQuotient op(R arg)
		{
			return op4impl(arg);
		}

		public Nonneg_onQuotient op(int arg)
		{
			return op4impl(new nilnul.num.real_.Nonneg_onQuotient(arg));
		}

		public NonnegI_onQuotient op(in NonnegI_onQuotient obj)
		{
			return op4impl(in obj);
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
