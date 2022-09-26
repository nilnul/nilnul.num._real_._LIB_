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
	public class LeOneDbl
		:
		nilnul.num.real.be_.nonneg_.leOne.vow.EeDbl
		,
		nilnul.num.real_.NonnegOfDoubleI
	{
		public LeOneDbl(double val) : base(val)
		{
		}

		public EeOfDouble realee => new EeOfDouble( this);
		

		static public LeOneDbl CreateByClamp(double x) {
			if (x<0)
			{
				return new LeOneDbl(0);
			}
			if (x>1)
			{
				return new LeOneDbl(1);
			}
			return new LeOneDbl(x);
		}
	}
}
