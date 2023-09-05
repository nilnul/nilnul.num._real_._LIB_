using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using R = nilnul.num.RealI;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.real.op_.unary_
{

	public class Sin
		: nilnul.num.real.op_.UnaryI

	{
		public R op(R arg)
		{
			return _Sin_byClampArgX.RetRealI(arg);

			//throw new NotImplementedException();
		}



		static public Sin Singleton
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Sin>.Instance;
			}
		}



	}
}
