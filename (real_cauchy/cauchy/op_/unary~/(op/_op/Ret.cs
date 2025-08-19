using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator._op
{
	[Obsolete("should inherit from a dynamic one")]
	public class Ret<TApproachOp>
		: Arg
		,
		GeneratorI
		where TApproachOp: nilnul.num._real.approach.OpI,new()
	{
		public Ret(GeneratorI arg) : base(arg)
		{
		}

		public ApproachI1 generate()
		{
			return SingletonByDefault<TApproachOp>.Instance.eval(arg.generate());
			throw new NotImplementedException();
		}
	}
}
