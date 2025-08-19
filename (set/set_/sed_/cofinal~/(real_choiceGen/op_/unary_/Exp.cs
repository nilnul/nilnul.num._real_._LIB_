using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;


namespace nilnul.num.real.op_.unary_
{
	public class Exp
		: nilnul.num.real.op_.UnaryI
	{


		public R op(R arg)
		{
			return new _exp.Ret(arg);
		}


		static public Exp Singleton
		{
			get
			{
				return nilnul.Singleton1<Exp>.Instance;
			}
		}

	}
}
