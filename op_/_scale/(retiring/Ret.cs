using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using nilnul.num._real.approach.generator.op_._negate;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;


namespace nilnul.num.real.op_._scale
{


	public class Ret
		: Arg
		, R
	{
		private Q _scale;

		public Q scale
		{
			get { return _scale; }
			set { _scale = value; }
		}

		public Ret(R arg,Q scale ) : base(arg)
		{
			_scale = scale;
		}

		public Ret(Qr scale, R x) : base(x)
		{
			this._scale=scale.q;
		}

		public GeneratorI choice
		{
			get
			{
				return nilnul.num._real.approach.generator.op_._ScaleX.Scale(
						arg.choice
						,_scale
					);
				//throw new NotImplementedException();
			}
		}
	}
}
