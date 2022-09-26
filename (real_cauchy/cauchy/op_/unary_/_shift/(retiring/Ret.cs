using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach.generator.op_._shift
{


	public class Ret : _op.Ret
		,
		GeneratorI
	{
		
		

		public Ret(GeneratorI arg, Q shift ) : this(arg, new nilnul.num._real.approach.op_.Shift(shift))
		{
		}
		public Ret(GeneratorI arg, nilnul.num._real.approach.op_.Shift shift)
			:base(arg,shift)
		{
		}

		
	}
}
