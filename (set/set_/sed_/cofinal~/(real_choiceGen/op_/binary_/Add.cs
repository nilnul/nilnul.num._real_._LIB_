using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient2;
using R = nilnul.num.RealI6;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;


namespace nilnul.num.real.op_.binary_
{
	public class Add1
		: BinaryI2
	{
		public const char Sign = '+';


		public R op(R a, R b)
		{
			if (a is nilnul.num.real_.Quotient2)
			{
				if (b is nilnul.num.real_.Quotient2)
				{
					var aAsQ = (Qr)a;
					var bAsQ = (Qr)b;
					return new nilnul.num.real_.Quotient2( aAsQ + bAsQ);
				}
				

			}
			return new _add.Ret1(a,b);

			//throw new NotImplementedException();
		}
		public override string ToString()
		{
			return Sign.ToString();
		}


		static public Add1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Add1>.Instance;
			}
		}




	}

	public static class AddX1
	{
		static public R Add(this R x, R y) {
			return binary_.Add1.Singleton.op(x, y);
		}

	}
}
