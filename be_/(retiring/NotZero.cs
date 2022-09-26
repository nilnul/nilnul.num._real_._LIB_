using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator.be;

namespace nilnul.num.real.be_
{
	public class NotZero
		: nilnul.num.real.BeI
	{
		public bool be(num.RealI2 obj)
		{
			return nilnul.num._real.approach.generator.be_.NotZero.Singleton.be(obj.choice);

			//throw new NotImplementedException();
		}

		static public readonly NotZero Singleton = SingletonByDefault<NotZero>.Instance;

		public class En : be.En<NotZero>
		{
			public En(num.RealI2 val) : base(val)
			{

			}


			



		}

	}
}
