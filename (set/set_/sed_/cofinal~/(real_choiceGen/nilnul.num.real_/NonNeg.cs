using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator;
using nilnul.num._real.approach.generator_;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonneg.vow;

namespace nilnul.num.real_
{
	[Obsolete()]
	public interface NonNegI
		:nilnul.num.RealI2
	{
	}

	[Obsolete()]
	public class NonNeg : nilnul.obj.Box<GeneratorI>
		,NonNegI
	{

		public NonNeg(GeneratorI val) : base(val)
		{
		}

		public NonNeg(RealI2 realI2)
		{
		}

		public GeneratorI choice => boxed;

		
	}


}
