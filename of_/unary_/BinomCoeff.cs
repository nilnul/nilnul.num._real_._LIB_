using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_
{
	static public class _BinomCoeffX
	{
		static public nilnul.num.Real _Op_assumeIntNonneg(int num, nilnul.num.RealI real ) {
			return _PermutateX._Op_assumeIntNonneg(num, real) / nilnul.num.op_.unary_._FactorialX._ByLoop_assumeNat(num);
			;
		}
	}
}
