using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;
using nilnul.num._real.approach;
using nilnul.num._real.approach.generator;
using nilnul.num._real.approach.generator_;
using nilnul.num._real.limit.sow;
using nilnul.num.real.be_.nonnil.vow;
using N = nilnul.num.real_.NonnilI;


namespace nilnul.num.real_.nonnil.op_.unary_._inverse
{
	[Obsolete()]
	public class Ret : nilnul.num.real_.nonnil._call.Arg, NonnilI
	{
		public Ret(N x) : base(x)
		{
		}
		public Ret(nilnul.num.RealI3 x) : this( new nilnul.num.real_.Nonnil(x))
		{
		}

		public CauchyI2 choice =>  _real.cauchy_.nonnil.op_.unary_._InverseX.Op(arg.choice).nonnil.en;

		public En nonnil => new En(this);

		public override string ToString()
		{
			return $"1/({arg})";
		}
	}
}