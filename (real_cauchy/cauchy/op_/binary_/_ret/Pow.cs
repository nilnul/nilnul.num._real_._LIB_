using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num._real.approach.generator.duo.op_._ret
{


	public class Pow : nilnul._call.argArg1_.Closed<GeneratorI>
		, GeneratorI
	{


		public Pow(GeneratorI arg, GeneratorI arg1) : base(arg, arg1)
		{


		}

		public ApproachI1 generate()
		{
			return _real.approach.duo.op_.Multi.Eval(arg.generate(), arg1.generate());

			//throw new NotImplementedException();
		}
		public override string ToString()
		{
			return $"{arg}{op_.Pow.Sign}{arg1}";
		}

	}
}
