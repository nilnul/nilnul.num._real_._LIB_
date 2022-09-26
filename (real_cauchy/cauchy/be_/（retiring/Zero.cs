using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.be_
{
	public class Zero : BeI
	{

		static public readonly Zero Singleton = SingletonByDefault<Zero>.Instance;

		public bool be(GeneratorI obj)
		{
			return _real.approach.be_.Nonzero.Singleton.not(obj.generate());

			//throw new NotImplementedException();
		}

	}

}
