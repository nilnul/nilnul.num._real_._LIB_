using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real.op_
{
	static public class _AbsX
	{
		static public nilnul.num.Real_onQuotient RetReal(nilnul.num.quotient_.DenomNonnil quotient)
		{

			return nilnul.num.quotient.op_._AbsX.Op(quotient);
		}

	}
	public class Abs :
		
		real.OpI1
	{


		public  R op(in R arg)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return _AbsX.RetReal(arg.current.begin);
			}

			return new _abs.Ret(arg);

		}

	

		static public Abs Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Abs>.Instance;
			}
		}

	}
}
