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


namespace nilnul.num.real.op_._shift
{


	public class Ret
		: Arg
		, R
	{
		private Q _shift;

		public Q shift
		{
			get { return _shift; }
			set { _shift = value; }
		}

		public Ret(R arg,Q scale ) : base(arg)
		{
			_shift = scale;
		}

		public Ret(Qr scale, R x) : base(x)
		{
			this._shift=scale.q;
		}

		public GeneratorI choice
		{
			get
			{
				return nilnul.num._real.approach.generator.op_._ShiftX.Shift(
						arg.choice
						,_shift
					);
				//throw new NotImplementedException();
			}
		}
	}
}
