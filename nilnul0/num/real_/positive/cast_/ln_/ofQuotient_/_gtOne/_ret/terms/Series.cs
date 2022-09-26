using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.real_.positive.cast_.ln_.ofQuotient_._gtOne._ret.terms
{
	/// <summary>
	/// the expansion of Ln(Q) to a series (accumulated sum of a stream)
	/// </summary>
	public class Series
		:
		nilnul.num.quotient.stream_.slider.cumulus_.Add
		

	{
		public Series(Q1 q) : base(new _ret.Terms(q))
		{
		}



		public nilnul.num.Quotient1 ySquared
		{
			get
			{
				return ((_ret.Terms)this.boxed).ySquared;
			}
		}

		public nilnul.num.Quotient1 argDec_div_argInc
		{
			get
			{
				return ((_ret.Terms)this.boxed).argDec_div_argInc;
			}
		}

		public nilnul.num.Quotient1 sliderIndex
		{
			get
			{
				return ((_ret.Terms)this.boxed).index;
			}
		}


	}
}