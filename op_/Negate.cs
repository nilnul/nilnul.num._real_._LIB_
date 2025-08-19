using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real.op_
{
	public class Neg
		:
		//UnaryA_retRealOnRealI,
		real.OpI1
	{


		public  R op(in R arg)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return new nilnul.num.real_.Quotient_denomNonnil (-arg.current.begin);
			}

			return new _neg.Ret(arg);

			//throw new NotImplementedException();
		}

	

		static public Neg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Neg>.Instance;
			}
		}
		
	}
}
