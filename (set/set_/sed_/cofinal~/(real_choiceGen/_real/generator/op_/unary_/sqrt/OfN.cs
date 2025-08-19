using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num._real.approach.generator.op.sqrt
{
	public class OfN:GeneratorI
	{

		private N _n;

		public N n
		{
			get { return _n; }
			set { _n = value; }
		}

		public OfN(N n)
		{
			_n = n;
		}

		public ApproachI1 generate()
		{
			return new  approach.op_.sqrt.call.OfN(_n);

			throw new NotImplementedException();
		}
	}
}
