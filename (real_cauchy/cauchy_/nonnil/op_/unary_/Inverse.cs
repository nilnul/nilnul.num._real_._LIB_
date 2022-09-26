using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.cauchy_.nonnil.op_.unary_
{
	static public class _InverseX 
	{
		static public NonnilI Op(NonnilI arg)
		{
			return new _inverse.Ret(arg);
		}

		static public NonnilI Op(nilnul.num._real.CauchyI2 arg)
		{
			return Op(new nilnul.num._real.cauchy_.Nonnil(arg));
		}

	}
}
