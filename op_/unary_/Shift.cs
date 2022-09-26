using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI;
namespace nilnul.num.real.op_.unary_
{
	static public class _ShiftX
	{
		static public Real Op( Q1 shift,  Q1 r) {
			return shift + r;
		}
		static public R Op_unsureQuotient( Q1 shift,  R r) {
			
			if (shift==0)
			{
				return r;
			}
	
			return new _shift._Ret_shiftNotZero(shift,r);
		}
		static public R Op( Q1 shift,  R r) {
			if (nilnul.num.real.be_.Quotient.Singleton.be(r))
			{
				return Op(shift, r.current.lower.mark);
			}
			return Op_unsureQuotient(shift,r);
			
	
		}

		internal static R Op(R realI, R a)
		{
			throw new NotImplementedException();
		}

		public static R Op(nilnul.num.real_.Quotient shift, R a)
		{
			return Op(shift.boxed,a);
		}
	}

	public class Shift1 
	{
		private Q1 _shift;
		public Shift1(Q1 shift)
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