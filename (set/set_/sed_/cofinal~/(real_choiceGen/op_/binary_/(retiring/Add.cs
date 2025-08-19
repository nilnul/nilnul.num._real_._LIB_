using nilnul.num._real.approach;
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


namespace nilnul.num.real.duo.op_
{
	public class Add
		: OpI
	{
		public const char Sign = '+';


		static public readonly Add Singleton = SingletonByDefault<Add>.Instance;


		public R eval(R a, R b)
		{
			if (a is nilnul.num.real_.Quotient)
			{
				if (b is nilnul.num.real_.Quotient)
				{
					var aAsQ = (Qr)a;
					var bAsQ = (Qr)b;
					return new Qr(aAsQ.q + bAsQ.q);
				}
				

			}
			return new _add.Call(a,b);

			//throw new NotImplementedException();
		}
		public override string ToString()
		{
			return Sign.ToString();
		}

		static public R Eval(R x, R y) {
			return Singleton.eval(x, y);
		}

		

	}

	public static class AddX
	{
		static public R Add(this R x, R y) {
			return duo.op_.Add.Eval(x, y);
		}

	}
}
