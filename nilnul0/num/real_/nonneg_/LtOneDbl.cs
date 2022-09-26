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
	public class LtOneDbl
		:
		nilnul.num.real.be_.nonneg_.ltOne.vow.EeDbl
		,
		nilnul.num.real_.NonnegOfDoubleI
	{
		public LtOneDbl(double val) : base(val)
		{
		}

		public EeOfDouble realee => new EeOfDouble( this);
		

		/// <summary>
		/// 1-double.Epsilon is used if given ge 1
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public LtOneDbl CreateByClamp(double x) {
			if (x<0)
			{
				return new LtOneDbl(0);
			}
			if (x>=1)
			{
				return new LtOneDbl(1-double.Epsilon);
			}
			return new LtOneDbl(x);
		}
	}
}
