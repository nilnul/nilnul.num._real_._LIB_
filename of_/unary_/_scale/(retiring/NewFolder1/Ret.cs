using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI3;
using nilnul.num._real.approach.generator.op_._negate;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient1;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;
using C = nilnul.num._real.CauchyI2;


namespace nilnul.num.real.op_.unary_._scale
{
	[Obsolete()]
	public class Ret
		: nilnul.num.real._call.Arg
		, R
	{
		private Q1 _scale;

		public Q1 scale
		{
			get { return _scale; }
			set { _scale = value; }
		}

		public Ret(R arg,Q1 scale ) : base(arg)
		{
			_scale = scale;
		}

		public Ret(Qr scale, R x) : base(x)
		{
			this._scale=scale.quotient;
		}

		public C choice
		{
			get
			{
				return nilnul.num._real.cauchy.op_.unary_._ScaleX.Scale(
						arg.choice
						,
						_scale
				);
				//throw new NotImplementedException();
			}
		}
	}
}
