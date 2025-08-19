using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_._scale.ret_
{
	/// <summary>
	/// if scale is zero, exception is dormant.
	/// </summary>
	public class ScaleNonnil
		: _call_.Arg
		,
		R
	{
		private nilnul.num.quotient_.Nonnil1 _scale;

		public nilnul.num.quotient_.Nonnil1 scale
		{
			get { return _scale; }
			set { _scale = value; }
		}
		public ScaleNonnil(nilnul.num.quotient_.Nonnil1 scale, R arg) : base(arg)
		{
			_scale = scale;
		}

		public ScaleNonnil(Q0 scale1, R r) : this(new Nonnil1(scale1), r)
		{
		}

		public ScaleNonnil(QuotientI1 scale1, R arg):this( new Nonnil1(scale1), arg )
		{
		}

		public nilnul.num.quotient.bound_.Closed current => nilnul.num.quotient.bound_.closed.op_.unary_._ScaleX.Scale(
					_scale
					, arg.current
				);
		public void squeeze(quotient_.Positive1 diameter)
		{
			arg.squeeze(
				 new quotient_.Positive1(
					diameter / nilnul.num.quotient.op_.unary_.Abs.Singleton.op(_scale)
				)
			);
		}
	}
}
