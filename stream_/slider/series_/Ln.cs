using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.real.stream_.slider.series_
{
	/// <summary>
	/// the expansion of Ln(Q) to a series (accumulated sum of a stream)
	/// </summary>
	public class Ln
		:
		nilnul.num.real.stream_.slider.cumulus_.Series
		

	{
		public Ln(RealI q) : base(new _ln.Slider(q))
		{
		}

		public Ln(nilnul.num.real_.Positive q) : base(
			new _ln.Slider(q)
		)
		{
		}

		public nilnul.num.RealI geometricTerm
		{
			get
			{
				return ((_ln.Slider)this.boxed).geometricTerm;
			}
		}

		public nilnul.num.RealI argDecDivArgInc_Squared
		{
			get
			{
				return ((_ln.Slider)this.boxed).ySquared;
			}
		}

		public nilnul.num.RealI argDec_div_argInc
		{
			get
			{
				return ((_ln.Slider)this.boxed).argDec_div_argInc;
			}
		}

		public BigInteger sliderIndex
		{
			get
			{
				return ((_ln.Slider)this.boxed).index;
			}
		}


	}
}