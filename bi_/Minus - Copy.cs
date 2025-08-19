
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI_onQuotient;


using System.Numerics;
using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;

namespace nilnul.num.real.of_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		subtraction
	public class Minus
		: BinaryI
	{
		public const char Sign = '-';

		public R op(R a, R b)
		{
			if (object.ReferenceEquals(a,b))
			{
				return new nilnul.num.Real_onQuotient( );
			}


			return Add.Singleton.op(a, op_.Neg.Singleton.op(b));
		}

		public R op(R a, nilnul.num.real_.Quotient_denomNonnil b)
		{
			return real.op_._ShiftX.Op(-(b), a );

		}


		public override string ToString()
		{
			return Sign.ToString();
		}

		public R op(int v, R val)
		{
			return op(v, val.ToImpl() );
			
		}

		public R op(int v, Real_onQuotient val)
		{
			return real.of_.binary_.Add.Singleton.op(v, -val );
			
		}

		public R op(nilnul.num.real_.Quotient_denomNonnil quotient1, R realI)
		{
			return of_.binary_.Add.Singleton.op(
				quotient1,
				-realI.ToImpl()
			);//.Lazy.op(;
		}
	

		public R op(quotient_.DenomNonnilI quotient1, Real_onQuotient realI)
		{
			return op_.binary_.Add.Singleton.op(
				quotient1,
				-realI
			);//.Lazy.op(;
		}

		public R op(quotient_.DenomNonnilI quotient1, R realI)
		{
			return op(
				quotient1,
				realI.ToImpl()
			);//.Lazy.op(;
		}

	

		public  R op(R result, BigInteger floor)
		{
			return real.of_.binary_.Add.Singleton.op(result, floor);
		}

		public R0 op(Real_onQuotient a, DenomNonnil b)
		{
			return real.of_.binary_.Add.Singleton.op(a,-b);

		}
		public R0 op(Real_onQuotient a, DenomNonnilI b)
		{
			return real.of_.binary_.Add.Singleton.op(a,- b.ToImpl());

		}


		static public Minus Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minus>.Instance;
			}
		}
	}
}
