using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI3;
using nilnul.num._real.approach.generator.op_._negate;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;
using nilnul.num.quotient.stream_;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num.real.op_.unary_._shift
{


	public class Ret
		: nilnul.num.real._call.Arg
		, R
	{
		private Q1 _shift;

		public Q1 shift
		{
			get { return _shift; }
			set { _shift = value; }
		}

		public Ret(R arg,Q1 shift ) : base(arg)
		{
			_shift = shift;
		}

		public Ret(Q1 shift, R x) : base(x)
		{
			this._shift=shift;
		}

		
		public C choice => nilnul.num._real.cauchy.op_.unary_._ShiftX.Shift(this._shift, this.arg.choice);
	}
}
