using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num._real.approach.op_.uni_._cos.of_._quotient
{
	public class Series
		: nilnul.num.quotient.slider.Series
	{
		public Series(Q1 slider) : base(
			new _series.Term(slider)	
		)
		{
		}

		
	}
}
