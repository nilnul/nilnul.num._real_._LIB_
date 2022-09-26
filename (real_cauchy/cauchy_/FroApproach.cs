using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator_
{
	public class FroApproach:GeneratorI
	{
		private num._real.ApproachI1 _approach;

		public num._real.ApproachI1 approach
		{
			get { return _approach; }
			set { _approach = value; }
		}

		public FroApproach(ApproachI1 approach)
		{
			_approach = approach;
		}

		public ApproachI1 generate()
		{
			return _approach;
		}
	}
}
