using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.op.Abs.Ed;

namespace nilnul.num._real.limit.cofinal.single
{
	public class SqrtOfN
		:Singleton
	{
		public SqrtOfN(N n):base(
			new num._real.limit.op.sqrt.call.OfN(n)
		)
		{


		}
	}
}
