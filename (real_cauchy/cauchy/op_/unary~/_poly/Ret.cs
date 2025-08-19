using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num._real.approach.generator.op_._poly
{
	public class Ret
		: Arg
		,
		GeneratorI
	{
		private N _index;

		public N index
		{
			get { return _index; }
			set { _index = value; }
		}

		public Ret(GeneratorI arg , N index) : base(arg)
		{
			_index = index;
		}

		public ApproachI1 generate()
		{
			return nilnul.num._real.approach.op_.Poly.Eval( arg.generate(), _index);
		}
	}
}
