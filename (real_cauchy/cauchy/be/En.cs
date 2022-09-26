using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.be
{
	public class En<TBe>
		: nilnul.be.Asserted<GeneratorI, TBe>
		where TBe : nilnul.num._real.approach.generator.BeI, new()
	{
		public En(GeneratorI val) : base(val)
		{
		}
	}
}
