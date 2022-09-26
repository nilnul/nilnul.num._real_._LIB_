using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num._real.cauchy.op_.unary_
{
	public class Negate
		: UnaryI
	{

		static public readonly Negate Singleton = SingletonByDefault<Negate>.Instance;

		public C op(C arg)
		{
			return new _negate.Ret(arg);
		}

		
	}
}
