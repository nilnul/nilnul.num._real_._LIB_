using System;
using q = nilnul.num.quotient;
using Range = nilnul.num.quotient.ext.border.duo.be.Range.Asserted;


namespace nilnul.num.real._real
{
	public interface RealI
		
	{

		nilnul.num.quotient.ext.border.duo.be.Range.Asserted range{ get; }
		void converge(nilnul.num.quotient.be.Positive.Asserted diameter);
	}
}
