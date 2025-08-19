using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI3;
using Rq = nilnul.num.real_.Quotient1;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient1;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num.real.op_.binary_._multi
{
	[Obsolete()]
	public class Ret :
		nilnul.num.real._call.ArgArg1
		,
		R
	{
		public Ret(R arg, R arg1) : base(arg, arg1)
		{
		}

		public C choice
		{
			get
			{
				return  num._real.cauchy.op_.binary_.Multi.Singleton.op(arg.choice, arg1.choice);
			}
		}

		public override string ToString()
		{
			return $"{ arg}{ Multi.Sign}{ arg1}";
		}
	}
}
