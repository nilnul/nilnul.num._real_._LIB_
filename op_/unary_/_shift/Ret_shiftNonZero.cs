using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using Q0 = nilnul.num.Quotient1;
using R = nilnul.num.RealI;
using A = nilnul.num.RealI;
using nilnul.num.quotient;
using B = nilnul.num.quotient.bound_.Closed;

namespace nilnul.num.real.op_.unary_._shift
{
	/// <summary>
	/// if scale is zero, exception is dormant.
	/// </summary>
	public class _Ret_shiftNotZero
		:_call_.Arg
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
		public B current =>  nilnul.num.quotient.bound_.closed.op_.unary_._ShiftX.Op(
			_shift
			,arg.current	
		);

		public void squeeze(quotient_.Positive1 diameter)
		{
			arg.squeeze(
					diameter
			);
		}
	}
}