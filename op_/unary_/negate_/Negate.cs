using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI3;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.op_.unary_
{
	public class Negate : UnaryI
	{

		static public readonly Negate Singleton = SingletonByDefault<Negate>.Instance;

		public A op(A arg)
		{
			return new _negate.Ret(arg);
		}

		
	}
}
