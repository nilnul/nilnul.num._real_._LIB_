using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num._real.approach.generator.duo.op_
{
	public class Pow
		:OpI
	{
		public const char Sign = '^';
		static public readonly Pow Singleton = SingletonByDefault<Pow>.Instance;

		public GeneratorI eval(GeneratorI a, GeneratorI b)
		{
			return new _ret.Pow(a, b);

			//throw new NotImplementedException();
		}



		static public GeneratorI Square(GeneratorI a) {
			return Singleton.eval(a, a);
		}


	}
}
