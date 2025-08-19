using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_
{
	static public class _NegX
	{
		static public nilnul.num.Real Op(nilnul.num.Quotient1 quotient) {

			return -quotient;
		}
	}
	public class Neg :
		UnaryA_retRealOnRealI,
		UnaryI
	{


		public override R op(R arg)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return _NegX.Op(arg.current.lower.mark);
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
