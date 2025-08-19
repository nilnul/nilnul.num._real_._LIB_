using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._real.approach;
using nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI3;

namespace nilnul.num._real._cauchy.approach.op_.unary_._scale
{
	/// <summary>
	/// if scale is zero, exception is dormant.
	/// </summary>
	public class Ret
		:approach._call.Arg
		,
		ApproachI
	{
		private nilnul.num.quotient_.Nonnil _scale;

		public nilnul.num.quotient_.Nonnil scale
		{
			get { return _scale; }
			set { _scale = value; }
		}
		public Ret(nilnul.num.quotient_.Nonnil scale, ApproachI arg):base(arg)
		{
			_scale = scale;
		}


		public Range1 range => nilnul.num.quotient.range.op_.unary_._ScaleX.Scale(
					_scale
					, arg.range
				);
		public void squeeze(quotient_.Positive1 diameter)
		{
			if (_scale.en == 0)
			{
				return;
			}

			arg.squeeze(
				 new quotient_.Positive1(
					diameter / nilnul.num.quotient.op_.unary_.Abs.Singleton.op(_scale)	
				)
			);
			
			//throw new NotImplementedException();
		}

		
	}
}
