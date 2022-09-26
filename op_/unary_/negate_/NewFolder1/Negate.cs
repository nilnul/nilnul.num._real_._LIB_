using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI2;

namespace nilnul.num._real.approach.op_
{
	public class Negate : OpI
	{

		static public readonly Negate Singleton = SingletonByDefault<Negate>.Instance;

		public ApproachI1 eval(ApproachI1 arg)
		{
			return new _negate.Call(arg);
			throw new NotImplementedException();
		}

		

	}
}
