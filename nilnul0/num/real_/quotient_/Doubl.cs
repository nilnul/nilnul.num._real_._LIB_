using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient_
{
	static public class _DoublX
	{
		static public nilnul.num.real_.Quotient Construct_precisionDenom(double x, int precisionDenom ) {
			return new nilnul.num.real_.Quotient(
				nilnul.num.quotient_._DoublX.Constuct_precisionDenom(x, precisionDenom)
			)
			;
		}
	}
}
