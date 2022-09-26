using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator.be;

namespace nilnul.num.real.be_
{
	[Obsolete()]
	public class Zero
		: nilnul.num.real.BeI
	{

		static public bool Be(num.RealI2 obj) {
			return nilnul.num._real.approach.generator.be_.Zero.Singleton.be( obj.choice);

		}
		public bool be(num.RealI2 obj)
		{
			return nilnul.num._real.approach.generator.be_.Zero.Singleton.be( obj.choice);

			//throw new NotImplementedException();
		}


		static public readonly Zero Singleton = SingletonByDefault<Zero>.Instance;



		public class En : be.En<Zero>
		{
			public En(num.RealI2 val) : base(val)
			{

			}


			



		}

	}
}
