using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.generator.op_
{
	public class Negate
		: OpI
	{

		static public readonly Negate Singleton = SingletonByDefault<Negate>.Instance;

		public GeneratorI eval(GeneratorI arg)
		{
			return new _negate.Ret(arg);
			throw new NotImplementedException();
		}

		
	}
}
