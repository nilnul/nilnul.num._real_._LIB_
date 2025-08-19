using System;
using nilnul.num._real.approach;

namespace nilnul.num._real.approach.generator.op_._exp
{
	public  class Ret : GeneratorI
	{
		private GeneratorI arg;

		public Ret(GeneratorI arg)
		{
			this.arg = arg;
		}

		public ApproachI1 generate()
		{
			return _real.approach.op_.Exp.Singleton.eval(arg.generate());
//			throw new NotImplementedException();
		}
	}
}