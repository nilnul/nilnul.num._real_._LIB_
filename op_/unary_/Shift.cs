using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R1 = nilnul.num.RealI;
namespace nilnul.num.real.op_.unary_
{
	static public class _ShiftX
	{
		static public Real Op( Q1 shift,  Q1 r) {
			return shift + r;
		}
		static public R1 Op_unsureQuotient( Q1 shift,  R1 r) {
			
			if (shift==0)
			{
				return r;
			}
	
			return new _shift._Ret_shiftNotZero(shift,r);
		}
		static public R1 Op( Q1 shift,  R1 r) {
			if (nilnul.num.real.be_.Quotient.Singleton.be(r))
			{
				return Op(shift, r.current.lower.mark);
			}
			return Op_unsureQuotient(shift,r);
			
	
		}

		

		public static R1 Op(nilnul.num.real_.Quotient shift, R1 a)
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
		public R1 op(R1 arg)
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