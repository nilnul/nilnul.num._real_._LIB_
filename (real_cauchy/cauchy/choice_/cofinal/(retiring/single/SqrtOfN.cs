using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.limit.sow;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using N = nilnul._num.bigint.be.Natural.Asserted;
using nilnul.num._real;

namespace nilnul.num._real.single
{
	/// <summary>
	/// </summary>
	public class SqrtOfN:

		_real.cofinal.Singleton
	{
		

		public SqrtOfN(N q)
			:base(new _real.approach.froSqueeze.SqrtOfN(q))
		{
			
		}

		

		


	

		


	}


}
