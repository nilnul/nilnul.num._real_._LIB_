using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI3;
namespace nilnul.num._real._cauchy.approach.op_.unary_
{
	static public class _ShiftX
	{
		static public ApproachI Shift( Q1 shift,  ApproachI r) {
			if (shift==0)
			{
				return r;
			}
			return new _shift._Ret_shiftNotZero(shift,r);
		}

		
	}

	public class Shift 
	{
		private Q1 _shift;
		public Shift(Q1 shift)
		{
			_shift = shift;
		}
		public ApproachI eval(ApproachI arg)
		{
			return _ShiftX.Shift(_shift, arg);
		}

		static private Lazy<Shift> _Lazy = new Lazy<Shift>();
		static public Shift Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}
	}
}