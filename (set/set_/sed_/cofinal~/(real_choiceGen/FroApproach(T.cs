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
	public class FroApproach<T>
		:FroGenerator,
		RealI2

		where T:_real.ApproachI1,new()
	{
		

		public FroApproach( )
			:base( new _real.approach.generator_.FroApproach<T>(
				
				)
				 )
		{
			

		}

		


	}

	

	
}
