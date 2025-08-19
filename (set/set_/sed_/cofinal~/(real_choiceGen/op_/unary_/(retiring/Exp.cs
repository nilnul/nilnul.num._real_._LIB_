using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;


namespace nilnul.num.real.op_
{
	public class Exp
		: nilnul.num.real.OpI2
	{

		static public readonly Exp Singleton = SingletonByDefault<Exp>.Instance;

		public R eval(R arg)
		{
			return new _exp.Ret(arg);
		}
	}
}
