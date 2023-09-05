using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using R = nilnul.num.RealI;//._cauchy.ApproachI;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.real.op_.unary_
{


	public class Cos
		: nilnul.num.real.op_.UnaryI

	{
		public R op(R arg)
		{

			return _Cos_byClampArgX.RealI(arg);
			//throw new NotImplementedException();
		}

		static public Cos Singleton
		{
			get
			{
				return nilnul.Singleton1<Cos>.Instance;
			}
		}




	}
}
