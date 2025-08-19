using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.generator.op_
{
	public class Sqrt
		: OpI
	{



		static public readonly Sqrt Singleton = SingletonByDefault<Sqrt>.Instance;

		public GeneratorI eval(GeneratorI arg)
		{
			return new _sqrt.Ret(arg);
			throw new NotImplementedException();
		}

		
	}
}
