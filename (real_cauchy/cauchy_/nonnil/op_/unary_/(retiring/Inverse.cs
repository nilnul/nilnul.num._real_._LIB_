using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator_.notZero.op_
{
	public class Inverse : OpI
	{

		static public readonly Inverse Singleton = SingletonByDefault<Inverse>.Instance;

		public NotZeroI eval(NotZeroI arg)
		{
			return new _inverse.Ret(arg);

			throw new NotImplementedException();
		}
	}
}
