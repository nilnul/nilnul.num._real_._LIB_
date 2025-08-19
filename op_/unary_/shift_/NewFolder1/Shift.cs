using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.op_
{
	static public class _ShiftX
	{

		static public ApproachI1 Shift(this ApproachI1 r, Q shift) {

			if (shift==0)
			{
				return r;

			}
			return new _shift._Ret_shiftNotZero(shift,r);

		}
		
	}

	public class Shift : OpI
	{
		private Q _shift;
		public Shift(Q shift)
		{
			_shift = shift;
		}
		public ApproachI1 eval(ApproachI1 arg)
		{
			return _ShiftX.Shift(arg, _shift);
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
