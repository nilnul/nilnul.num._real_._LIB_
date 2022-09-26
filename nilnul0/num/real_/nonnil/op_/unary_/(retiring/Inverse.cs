using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;
using nilnul.num._real.limit.sow;
using R = nilnul.num.RealI2;


namespace nilnul.num.real_.notZero.op_
{
	[Obsolete()]
	public class Inverse : nilnul.OpI<NotZeroI>
	{

		static public double _Eval(double x_nonZero)
		{
			return 1 / x_nonZero;
		}

		public static readonly Inverse Singleton = SingletonByDefault<Inverse>.Instance;

		public R _eval(RealI2 asCubicMeters)
		{
			return eval(
				new NotZero(asCubicMeters)
			);

			//throw new NotImplementedException();
		}

		public NotZeroI eval(NotZeroI arg)
		{
			return new _inverse.Call(arg);

			//throw new NotImplementedException();
		}



			public NotZeroI eval(R arg)
		{
			return eval( new NotZero(arg) );

			//throw new NotImplementedException();
		}

		public NotZeroI eval(Natural.Asserted b)
		{
			return eval( new nilnul.num.real_.Quotient(b.val)  );
			throw new NotImplementedException();
		}
	}
}
