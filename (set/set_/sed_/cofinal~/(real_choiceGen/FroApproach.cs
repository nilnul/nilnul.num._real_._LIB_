using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;
using nilnul.num._real.approach;

namespace nilnul.num.real_
{
	public class FroApproach 
		:FroGenerator,
		RealI2
	{
		

		public FroApproach(num._real.ApproachI1 approach)
			:base(
				 new num._real.approach.generator_.FroApproach(approach)
				 )
		{
			

		}

		


	}

	

	
}
