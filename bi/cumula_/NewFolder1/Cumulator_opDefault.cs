using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_.binary;

namespace nilnul.num.real.op_.binary
{
	[Obsolete()]
	public class Cumulator_opDefault<TOp>
		:
		nilnul.obj.op_.binary.Accumulator_opGenericDefault<nilnul.num.RealI, TOp>
		,CumulatorI

		where TOp : nilnul.num.real.op_.BinaryI, new()
	{
		public Cumulator_opDefault(RealI initial) : base(initial)
		{
		}

	}
	


}
