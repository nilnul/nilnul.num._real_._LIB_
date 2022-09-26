using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_.geometric_.std
{
	static public class _CumulusX
	{
		static public nilnul.num.RealI SumUp2numero(
			nilnul.num.real_.NotOneI rate
			,
			nilnul.Num1 numero
		) {
			var r = rate.ToReal();
			return (
				1
				-
				num.real.op_.unary_._PolyX.RealI(rate, numero+1).ToReal()
			)
			/
			(1 - r);
		}
	}
}
