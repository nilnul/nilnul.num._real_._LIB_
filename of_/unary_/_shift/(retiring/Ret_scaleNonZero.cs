using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._real.approach;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.op_._shift
{
	/// <summary>
	/// if scale is zero, exception is dormant.
	/// </summary>
	public class _Ret_shiftNotZero
		:Arg
		,
		ApproachI1
	{
		private Q _shift;

		public Q shift
		{
			get { return _shift; }
			set { _shift = value; }
		}
		public _Ret_shiftNotZero(Q shift, ApproachI1 arg):base(arg)
		{
			_shift = shift;
		}

		public Nonempty.En bound
		{
			get
			{
				return nilnul.num.quotient.range.op_.Shift.Eval(
					_shift
					,arg.bound	
				);
				//throw new NotImplementedException();
			}
		}

		public void clamp(Positive1.En diameter)
		{

			arg.clamp(
					diameter
			);
		}
			
	}
}
