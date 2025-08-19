using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.op_
{
	[Obsolete("shall inherit from dynamic generic one")]
	public class FroApproachOp<TApproachOP>
		: OpI
		where TApproachOP : nilnul.num._real.approach.OpI, new()
	{
		public GeneratorI eval(GeneratorI arg)
		{
			return new _op.Ret<TApproachOP>(arg);
		}
	}
}
