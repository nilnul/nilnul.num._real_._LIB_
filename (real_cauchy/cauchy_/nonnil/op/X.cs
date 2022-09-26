using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator_.nonzero.op
{
	static public class X
	{
		static public generator_.NotZeroI  _Inverse(this GeneratorI g) {
			return Inverse(
				new generator_.NotZero(g)	
			);
			
		}

		static public generator_.NotZeroI Inverse(this generator_.NotZeroI x) {
			return new generator_.notZero.op_._inverse.Ret(x);
		}
	}
}
