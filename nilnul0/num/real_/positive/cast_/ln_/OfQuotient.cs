using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positive.cast_.ln_
{
	static public class _OfQuotientX
	{
		static public nilnul.num.RealI _AssumePositive(nilnul.num.Quotient1 quotient) {
			if (quotient==1)
			{
				return new nilnul.num.real_.Quotient();
			}

			if (quotient>1)
			{
				return new ofQuotient_._gtOne.Ret(quotient);
			}
			return - new  ofQuotient_._gtOne.Ret( nilnul.num.quotient.op_.unary_._InverseX.Op(quotient)  ).ToReal();
		}
	}
}
