using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.num.real.be.en_;
using nilnul.num.real.be_.nonneg.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positive_
{
	public class LeOneDbl
		:
		nilnul.num.real.be_.positive_.leOne.vow.Ee4dbl
		,
		nilnul.num.real_.PositiveDblI
	{
		public LeOneDbl(double val) : base(val)
		{
		}

		public EeOfDouble realee => new EeOfDouble( this);

		public BeDefaultedDbl<real.be_.PositiveDbl> dblen => new BeDefaultedDbl<real.be_.PositiveDbl>(this);

		static public LeOneDbl CreateByClamp(double x) {
			if (x<=0)
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
