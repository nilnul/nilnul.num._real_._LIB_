using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI3;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient2;
using Rx = nilnul.num.RealX;//.real.all.RealX;
using nilnul.num.real.all;


namespace nilnul.num.real.op_.binary_
{
	[Obsolete()]
	public class Minus
		: BinaryI1
	{
		public const char Sign = '-';


		static public readonly Minus Singleton = SingletonByDefault<Minus>.Instance;


		public R op(R a, R b)
		{
			return Add.Singleton.op(a, op_.unary_.Neg.lazy.op(b));

		}
		public override string ToString()
		{
			return Sign.ToString();
		}


		public R op(int v, R val)
		{

			return op(
				(nilnul.num.real_.Quotient2)v,val
			);
			//throw new NotImplementedException();
		}

		
	}
}
