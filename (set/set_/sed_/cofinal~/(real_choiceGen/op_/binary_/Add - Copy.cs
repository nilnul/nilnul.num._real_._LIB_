using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient1;
using R = nilnul.num.RealI3;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;


namespace nilnul.num.real.op_.binary_
{
	[Obsolete()]
	public class Add
		: BinaryI1
	{
		public const char Sign = '+';


		static public readonly Add Singleton = SingletonByDefault<Add>.Instance;


		public R op(R a, R b)
		{
			if (a is nilnul.num.real_.Quotient1)
			{
				if (b is nilnul.num.real_.Quotient1)
				{
					var aAsQ = (Qr)a;
					var bAsQ = (Qr)b;
					return new nilnul.num.real_.Quotient1( aAsQ + bAsQ);
				}
				

			}
			return new _add.Ret(a,b);

			//throw new NotImplementedException();
		}
		public override string ToString()
		{
			return Sign.ToString();
		}

	

		

	}

	public static class AddX
	{
		static public R Add(this R x, R y) {
			return binary_.Add.Singleton.op(x, y);
		}

	}
}
