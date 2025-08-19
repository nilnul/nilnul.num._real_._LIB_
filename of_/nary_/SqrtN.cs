using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI2;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;


namespace nilnul.num._real.approach.construct_
{
	public class Sqrt : ConstructI<nilnul.Num>
	{
		public ApproachI1 construct(nilnul.Num precedent)
		{
			return new _sqrtN.Ret(precedent);
			throw new NotImplementedException();
		}

		static public readonly Sqrt Singleton = nilnul.obj.SingletonByDefault<Sqrt>.Instance;

	}
}
