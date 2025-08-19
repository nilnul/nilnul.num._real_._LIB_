using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;

namespace nilnul.num._real.approach.generator.cofinal.eg.single
{
	public class GeneratorNew<T>
		: 
		Singleton
		where T:GeneratorI,new()
	{
		public GeneratorNew()
			:base(new T())
		{

		}

	}
}
