using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonneg.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg_
{
	public class LtTauOfDouble
		:
		nilnul.num.real.be_.nonneg_.ltTau.vow.EeOfDouble
		,
		nilnul.num.real_.NonnegOfDoubleI
	{
		public LtTauOfDouble(double val) : base(val)
		{
		}

		public EeOfDouble realee => new EeOfDouble( this);
	}
}
