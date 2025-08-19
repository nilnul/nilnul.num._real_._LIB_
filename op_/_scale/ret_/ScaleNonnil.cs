using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.real_;

using Q0 = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real.op_._scale.ret_
{
	/// <summary>
	/// if scale is zero, exception is dormant.
	/// </summary>
	public class ScaleNonnil
		: calc_._unary.Arg
		,
		R
	{
		private nilnul.num.quotient_.denomNonnil_.Nonnil _scale;

		public nilnul.num.quotient_.denomNonnil_.Nonnil scale
		{
			get { return _scale; }
			set { _scale = value; }
		}
		public ScaleNonnil(nilnul.num.quotient_.denomNonnil_.Nonnil scale, R arg) : base(arg)
		{
			_scale = scale;
		}

		public ScaleNonnil(Q0 scale1, R r) : this(new quotient_.denomNonnil_.Nonnil (scale1), r)
		{
		}

		public ScaleNonnil(quotient_.DenomNonnilI scale1, R arg):this( new quotient_.denomNonnil_.Nonnil(scale1), arg )
		{
		}

		public Clamp current => nilnul.num.quotient.clamp.op_._ScaleX.Scale(
					_scale.eeByRef.ToImpl()
					,
					arg.current
				);
		public void cinch(quotient_.denomNonnil_.Positive diameter)
		{
			arg.cinch(
				 new quotient_.denomNonnil_.Positive(
					 num.quotient_.denomNonnil._ExtensionsX.ToImpl(
						diameter.eeByRef
					)/  nilnul.num.quotient.op_.unary_._AbsX.Op(_scale)
				)
			);
		}
	}
}
