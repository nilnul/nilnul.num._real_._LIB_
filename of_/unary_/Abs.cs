using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_
{
	static public class _AbsX
	{
		static public nilnul.num.Real RetReal(nilnul.num.Quotient1 quotient)
		{

			return nilnul.num.quotient.op_.unary_.Abs.Singleton.op(quotient);
		}

	}
	public class Abs :
		UnaryA_retRealOnRealI
		,
		UnaryI
	{


		public override R op(R arg)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return _AbsX.RetReal(arg.current.lower.mark);
			}

			return new _abs.Ret(arg);

			//throw new NotImplementedException();
		}

		//public Real op_retReal(R arg)
		//{
		//	return new Real(op(arg));
		//}

		static public Abs Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Abs>.Instance;
			}
		}

	}
}
