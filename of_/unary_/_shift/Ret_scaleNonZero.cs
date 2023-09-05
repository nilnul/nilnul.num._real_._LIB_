using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._real.approach;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using Q0 = nilnul.num.Quotient1;
using R = nilnul.num.RealI3;
using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num.quotient;

namespace nilnul.num._real._cauchy.approach.op_.unary_._shift
{
	/// <summary>
	/// if scale is zero, exception is dormant.
	/// </summary>
	public class _Ret_shiftNotZero
		:approach._call.Arg
		,
		A 
	{
		private Q0 _shift;

		public Q0 shift
		{
			get { return _shift; }
			set { _shift = value; }
		}
		public _Ret_shiftNotZero(Q0 shift, A arg):base(arg)
		{
			_shift = shift;
		}
		public Range1 range =>  nilnul.num.quotient.range.op_.unary_._ShiftX.Op(
			_shift
			,arg.range	
		);

		public void squeeze(quotient_.Positive1 diameter)
		{
			arg.squeeze(
					diameter
			);
		}
	}
}