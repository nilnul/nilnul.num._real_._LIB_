using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI2;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using Rx = nilnul.num.real.RealX;
using nilnul.num.real.all;


namespace nilnul.num.real.combine_
{
	public class Minus
		: CombineI
	{
		public const char Sign = '-';


		static public readonly Minus Singleton = SingletonByDefault<Minus>.Instance;


		public R eval(R a, R b)
		{


			if (a is nilnul.num.real_.Quotient)
			{
				var aAsQ = (Qr)a;
				if (b is nilnul.num.real_.Quotient)
				{
					var bAsQ = (Qr)b;

					return nilnul.num.real_.quotient.combine_.Minus.Singleton.eval(aAsQ.q , bAsQ.q);
				}
				else
				{
					return new nilnul.num.real.op_.Shift(a as nilnul.num.real_.Quotient).eval(nilnul.num.real.op_.Negate.lazy.eval( b));
				}

			}

			if (b is nilnul.num.real_.Quotient)
			{
				return eval(a, b);
			}


			return new Ed(a, b);
			//throw new NotImplementedException();
		}
		public override string ToString()
		{
			return Sign.ToString();
		}

		public class Ed :
			nilnul._call.argArg1_.Closed<R>
			,
			R
		{
			public Ed(R arg, R arg1) : base(arg, arg1)
			{
			}

			public GeneratorI choice
			{
				get
				{
					return new num._real.approach.generator.duo.op_.Minus.Ed(arg.choice,arg1.choice);
					throw new NotImplementedException();
				}
			}

			public override string ToString()
			{
				return $"{ arg}{ Minus.Sign}{ arg1}";
			}
		}

		public R eval(int v, R val)
		{

			return eval(
				(nilnul.num.real_.Quotient)v,val
			);
			//throw new NotImplementedException();
		}
	}
}
