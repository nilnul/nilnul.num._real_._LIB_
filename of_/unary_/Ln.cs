using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_
{
	public class Ln : UnaryI
	{
		public RealI op(RealI par)
		{
			return nilnul.num.real_.positive.ln_._ByReverseExpX.RetRealI(par);
		}

		public RealI op(Real v)
		{
			return op((RealI)v);
		}

		static public Ln Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ln>.Instance;
			}
		}

	}
}
