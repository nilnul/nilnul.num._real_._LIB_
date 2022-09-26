using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CofinalI = nilnul.num.RealI2;
using R1 = nilnul.num.RealI2;
using Quotient2 = nilnul.num.real_.Quotient;
using nilnul.num._quotient.fraction.op;
using nilnul.num.real.all;
using nilnul._num.bigint.be;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI2;
using Rx = nilnul.num.real.all.RealX;
using nilnul.num.real.all;



namespace nilnul.num.real.duo_.divisible.op_
{
	[Obsolete()]
	public class Div
	
	{
		public const char Sign = '*';

		


		static public readonly Div Singleton = SingletonByDefault<Div>.Instance;


		public CofinalI eval(CofinalI a, CofinalI b)
		{
			return new Ed(a, b);

			//throw new NotImplementedException();
		}

		public CofinalI eval(int  a, CofinalI b)
		{
			return eval( new Q1(a),b );

			//throw new NotImplementedException();
		}

		public CofinalI eval( CofinalI a, int b)
		{
			return eval( a,new Quotient2(b) );

			//throw new NotImplementedException();
		}

		public R1 half(R1 x) {
			return eval(x, 2);
		}



		public override string ToString()
		{
			return Sign.ToString();
		}

		public class Ed :
			nilnul._call.argArg1_.Closed<R1>
			,
			CofinalI
		{
			public Ed(CofinalI arg, CofinalI arg1) : base(arg, arg1)
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
				return $"{ arg}{ Div.Sign}{ arg1}";
			}
		}

		public R1 eval(Simplify.Ed1 a, R1 b)
		{
			return nilnul.num.real.op_._ScaleX.Scale(
				a
				, 
				nilnul.num.real_.notZero.op_.Inverse.Singleton.eval(b)
				
			);

			//throw new NotImplementedException();
		}

		public CofinalI eval(all.RealX a, Natural.Asserted b)
		{
			return eval(
				1/new Q1(
				b), a);


			throw new NotImplementedException();
		}

		public CofinalI eval(nilnul.num.Real a, Natural.Asserted b)
		{
			return eval(
				1/new Q1(
				b), a);


			//throw new NotImplementedException();
		}

	}

	
}
