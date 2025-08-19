using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.convert_.arctg_
{
	static public class _OfQuotientX
	{
		static public nilnul.num.RealI _ofAbsLtOneNeNil(nilnul.num.Quotient1 _absLtOne) {
			return new op_.unary_.arctg_._bySeries.ret_ ._ofAbsLtOneNeNil.AsReal(_absLtOne);
		}
		static public nilnul.num.RealI _ofAbsLtOne(nilnul.num.Quotient1 x) {
			if (x == 0)
			{
				return new nilnul.num.real_.Quotient( 0);
			}
			return _ofAbsLtOneNeNil(x);
		}

		static public nilnul.num.RealI _ofAbsLeOne(nilnul.num.Quotient1 x) {
			
			if (x==1)
			{
				return  nilnul.num.real_.TauX.Quarter;
			}
			if (x==-1)
			{
				return  -nilnul.num.real_.TauX.Quarter;
			}
			return _ofAbsLtOne(x);
		}

		static public Real _ofGtOne(nilnul.num.Quotient1 _gtOne)
		{
			return nilnul.num.real_.TauX.Quarter - _ofAbsLeOne(1 / _gtOne);
		}
		static public Real _ofLtNegOne(nilnul.num.Quotient1 _ltNegOne)
		{
			return - _ofGtOne(- _ltNegOne);
		}

		static public RealI Of(nilnul.num.Quotient1 q)
		{
			if (q < -1)
			{
				return _ofLtNegOne(q);
			}
			if (q> 1)
			{
				return _ofGtOne(q);
			}
			return _ofAbsLeOne(q);
		}


	}
}
