using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._op;
using R = nilnul.num.RealI2;

namespace nilnul.num.real_.nonNeg.op_
{
	public class Sqrt:OpI
	{

		static public readonly Sqrt Singleton = SingletonByDefault<Sqrt>.Instance;

		public NonNegI eval(RealI2 realI2)
		{
			return eval(new NonNeg(realI2));
			//throw new NotImplementedException();
		}



		///Unicode Character 'SQUARE ROOT' (U+221A)  
		/// 
		public const char CHAR = '\u221a';

		public num.RealI2 eval_retR(num.real_.NonNegI arg)
		{

			return new _sqrt.Ret(arg);
			//throw new NotImplementedException();
		}



		public num.RealI2 eval(int v)
		{
			return eval(new real_.Quotient(v));
			//throw new NotImplementedException();
		}

		private RealI2 eval(Quotient quotient)
		{

			return new _sqrt.Ret(quotient);

			//throw new NotImplementedException();
		}

		public NonNegI eval(NonNegI arg)
		{
			return new NonNeg(eval_retR(arg));

			//throw new NotImplementedException();
		}
	}
}
