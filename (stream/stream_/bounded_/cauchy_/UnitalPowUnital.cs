using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.bounded_.cauchy_
{
	/// <summary>
	/// x^x, when x approaches 0+, the limit is 1.
	/// if we think the unital converges slow, we can move the unital forward by more steps
	/// </summary>
	public class UnitalPowSelf :
		nilnul.num.real.stream_.SliderA
	{
		private nilnul.num.quotient.stream_.bounded_.cauchy_.Unital _unital=new quotient.stream_.bounded_.cauchy_.Unital();

		public nilnul.num.quotient.stream_.bounded_.cauchy_.Unital unital
		{
			get { return _unital; }
			set { _unital = value; }
		}


		
		public override RealI current =>
			nilnul.num.real_.positive.op_.unary_._PowX.RetRealI_makeBasePositive(
				unital.current,unital.current
			)
			;

		public override void moveNext()
		{
			_unital.moveNext();
			//throw new NotImplementedException();
		}
	}
}
