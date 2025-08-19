using nilnul.num._real_.clamp_;
using nilnul.num.quotient_.denomNonnil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.RealI_onQuotient;
namespace nilnul.num.real.op_
{
	static public class _ShiftX
	{
		static public real_.Quotient_denomNonnil Op( Q4 shift,  Q4 r) {
			return  shift + r;
		}
		static public R0 _Op_1asNonquotient(num.quotient_. DenomNonnilI shift,  R0 r) {

			return _Op_1asNonquotient(
				nilnul.num.quotient_.denomNonnil._ExtensionsX.ToImpl(shift)
				,
				r
			);
		}
		static public R0 _Op_1asNonquotient( Q4 shift,  R0 r) {
			
			if (shift.numerator.IsZero)
			{
				return r;
			}
	
			return new _shift._Ret_shiftNotZero(shift,r);
		}

		public static R0 Op(quotient_.DenomNonnilI shift, R0 r)
		{
			return Op(shift.ToImpl(),r);

		}

		static public R0 Op( Q4	 shift,  R0 r) {
			if (nilnul.num.real.be_.Quotient.Singleton.be(r))
			{
				return Op(shift, r.current.begin);
			}
			return _Op_1asNonquotient(shift,r);
		}
		static public R0 Op( Q4 shift,  Real_onQuotient r) {
			if (nilnul.num.real.be_.Quotient.Singleton.be(r))
			{
				return Op(shift, r.current.begin);
			}
			return _Op_1asNonquotient(shift,r);
		}

		static public R0 Op( int shift,  Real_onQuotient r) {
			
			return Op((Q4)shift,r);
		}

		static public R0 Op( BigInteger shift,  R0 r) {
			return Op((Q4)(shift),r);

		
			
	
		}


		public static R0 Op(quotient_.DenomNonnilI a, Real_onQuotient b)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(b))
			{
				return Op(a, b.current.begin);
			}
			return _Op_1asNonquotient(a,b);

		}
		

		public static R Op(nilnul.num.real_.Quotient_denomNonnil shift, R a)
		{
			return Op(shift.boxed,a);
		}

	}

	public class Shift1 
	{
		private Q4 _shift;
		public Shift1(Q4 shift)
		{
			_shift = shift;
		}
		public R op(R arg)
		{
			return _ShiftX.Op(_shift, arg);
		}

		static private Lazy<Shift1> _Lazy = new Lazy<Shift1>();
		static public Shift1 Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}
	}
}