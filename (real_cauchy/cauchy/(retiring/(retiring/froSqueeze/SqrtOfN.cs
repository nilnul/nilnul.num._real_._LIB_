using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num._real.approach.froSqueeze
{
	public class SqrtOfN:ApproachI
	{

		private N _n;

		public N n
		{
			get { return _n; }
			set { _n = value; }
		}

		public SqrtOfN(N n)
		{
			_n = n;
		}

		public SqueezeI converge()
		{
			return new squeeze.op.sqrt.call.OfN(_n);

			throw new NotImplementedException();
		}
	}
}
