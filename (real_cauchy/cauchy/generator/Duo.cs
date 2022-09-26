using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator
{
	public class Duo : nilnul.obj.Duo<GeneratorI>
	{
		public Duo(Tuple<GeneratorI, GeneratorI> tuple) : base(tuple)
		{
		}

		public Duo(GeneratorI item1, GeneratorI item2) : base(item1, item2)
		{
		}
	}
}
