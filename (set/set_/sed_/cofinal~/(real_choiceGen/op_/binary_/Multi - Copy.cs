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

namespace nilnul.num.real.op_.binary_
{
	[Obsolete()]
	public class Multi
		: BinaryI1
	{
		public const char Sign = '*';


		static public readonly Multi Singleton = SingletonByDefault<Multi>.Instance;


		public R op(R a, R b)
		{
			if (a is nilnul.num.real_.Quotient1)
			{
				var aAsQ = (Qr)a;
				if (b is nilnul.num.real_.Quotient1)
				{
					var bAsQ = (Qr)b;
					return new Qr( aAsQ.quotient * bAsQ.quotient);
				}
				return nilnul.num.real.op_.unary_._ScaleX.Scale(aAsQ, b);

			}

			return new _multi.Ret(a, b);

			//throw new NotImplementedException();
		}

		public R op(int  a, R b)
		{
			return op( new Rq(a),b );

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return Sign.ToString();
		}

	
	}

	
}
