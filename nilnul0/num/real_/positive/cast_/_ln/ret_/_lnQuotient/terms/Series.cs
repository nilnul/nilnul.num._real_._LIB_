using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.real_.positive.cast_.sup_._ln.ret_._lnQuotient.terms
{
	/// <summary>
	/// the expansion of Ln(Q) to a series (accumulated sum of a stream)
	/// </summary>
	public class Series
		:
		nilnul.num.quotient.stream_.slider.cumulus_.Add
		

	{
		public Series(Q1 q) : base(new _lnQuotient.Terms(q))
		{
		}



		public nilnul.num.Quotient1 ySquared
		{
			get
			{
				return ((_lnQuotient.Terms)this.boxed).ySquared;
			}
		}

		public nilnul.num.Quotient1 argDec_div_argInc
		{
			get
			{
				return ((_lnQuotient.Terms)this.boxed).argDec_div_argInc;
			}
		}

		public nilnul.num.Quotient1 sliderIndex
		{
			get
			{
				return ((_lnQuotient.Terms)this.boxed).index;
			}
		}


	}
}