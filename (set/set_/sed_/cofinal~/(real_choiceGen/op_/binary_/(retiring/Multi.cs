using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI2;
using R1 = nilnul.num.RealI2;
using Quotient2 = nilnul.num.real_.Quotient;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;


namespace nilnul.num.real.duo.op_
{
	[Obsolete()]
	public class Multi
		: OpI
	{
		public const char Sign = '*';


		static public readonly Multi Singleton = SingletonByDefault<Multi>.Instance;


		public R eval(R a, R b)
		{
			if (a is nilnul.num.real_.Quotient)
			{
				var aAsQ = (Qr)a;
				if (b is nilnul.num.real_.Quotient)
				{
					var bAsQ = (Qr)b;
					return new Qr( aAsQ.q * bAsQ.q);
				}
				return nilnul.num.real.op_._ScaleX.Scale(aAsQ, b);

			}

			return new Ed(a, b);

			//throw new NotImplementedException();
		}

		public R eval(int  a, R b)
		{
			return eval( new Quotient2(a),b );

			throw new NotImplementedException();
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
					return new num._real.approach.generator.duo.op_.Multi.Ed(arg.choice,arg1.choice);
					throw new NotImplementedException();
				}
			}

			public override string ToString()
			{
				return $"{ arg}{ Multi.Sign}{ arg1}";
			}
		}
	}

	
}
