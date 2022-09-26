using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.stream_._cauchy;
using C = nilnul.num._real.CauchyI2;


namespace nilnul.num._real.cauchy.op_.binary_
{
	public class Minus
		: BinaryI
	{
		public const char Sign = '+';
		static public readonly Minus Singleton = SingletonByDefault<Minus>.Instance;

		public C op(C a, C b)
		{
			return new _minus.Ret(a, b);
		}

		public C op(Quotient1 arg, C choice)
		{
			return new op_.unary_._shift.Ret(arg, choice);
			//throw new NotImplementedException();
		}
	}
}
