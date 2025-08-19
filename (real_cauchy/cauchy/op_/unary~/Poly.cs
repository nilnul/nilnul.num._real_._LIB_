using System;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num._real.approach.generator.op_
{
	public class Poly
		

	{
		public GeneratorI eval(GeneratorI arg, N index )
		{
			return new _poly.Ret(arg, index);
			throw new NotImplementedException();
		}

		static public readonly Poly Singleton = SingletonByDefault<Poly>.Instance;

	}
}