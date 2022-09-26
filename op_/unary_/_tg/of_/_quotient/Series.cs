using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num._real.approach.convert_._tg.of_._quotient
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Note: this is convergent when |x| &lt; tau/4,  in that:
	///		Lim (n ->; Inf) T(n+1) /T (n) 
	///		=   16 /(Tau)^2 * x^2.
	/// </remarks>
	public class Series
		: nilnul.num.quotient.slider.Series
	{
		public Series(Q1 x) : base(new _quotient._series.TermsGivenByUnreliableSrc(x))
		{
		}
	}
}
