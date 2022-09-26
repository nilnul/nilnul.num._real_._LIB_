using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.stream_._cauchy;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num._real.cauchy.op_.binary_
{
	public class Add
		: BinaryI
	{
		public const char Sign = '+';
		static public readonly Add Singleton = SingletonByDefault<Add>.Instance;

		public C op(C a, C b)
		{
			return new _add.Ret(a, b);
		}

		public C op(Quotient1 arg, C choice)
		{
			return  op_.unary_._ShiftX.Shift(arg, choice);
			//throw new NotImplementedException();
		}
	}
}
