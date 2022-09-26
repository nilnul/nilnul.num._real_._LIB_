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
namespace nilnul.num._real.approach.op_._scale
{
	/// <summary>
	/// if scale is zero, exception is dormant.
	/// </summary>
	public class _Ret_scaleNotZero
		:Arg
		,
		ApproachI1
	{
		private Q _scale;

		public Q scale
		{
			get { return _scale; }
			set { _scale = value; }
		}
		public _Ret_scaleNotZero(Q scale, ApproachI1 arg):base(arg)
		{
			_scale = scale;
		}

		public Nonempty.En bound
		{
			get
			{
				return nilnul.num.quotient.range.op_.Scale.Eval(
					_scale
					,arg.bound	
				);
				//throw new NotImplementedException();
			}
		}

		public void clamp(Positive1.En diameter)
		{

			arg.clamp(
				 new Positive1.En(
					diameter / nilnul.num.quotient.op_.Abs.Eval(_scale)	
				)
			);
			
			//throw new NotImplementedException();
		}
	}
}
