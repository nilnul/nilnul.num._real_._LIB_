using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using Q0 = nilnul.num.quotient_.DenomNonnil;
//using R = nilnul.num.RealI_onQuotient;
using A = nilnul.num.RealI_onQuotient;
using nilnul.num.quotient;
//using B = Clamp;

namespace nilnul.num.real.op_._shift
{
	/// <summary>
	/// </summary>
	public class _Ret_shiftNotZero
		:calc_._unary.Arg
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
		public Clamp current => (
			arg.current.begin + _shift
			,
			arg.current.end + _shift
		);

		public void cinch(quotient_.denomNonnil_.Positive diameter)
		{
			arg.cinch(
					diameter
			);
		}
	}
}