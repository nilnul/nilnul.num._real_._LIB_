using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator.be;

namespace nilnul.num.real.be_
{
	[Obsolete()]

	public class NonNeg
		: nilnul.num.real.BeI
	{
		public bool be(num.RealI2 obj)
		{
			return  nilnul.num._real.approach.generator.be_.NonNeg.Singleton.be( obj.choice);

			//throw new NotImplementedException();
		}


		static public readonly NonNeg Singleton = SingletonByDefault<NonNeg>.Instance;

		public class Aver:be.Aver<NonNeg>
		{

		}

		public class En : be.En<NonNeg>
		{
			public En(num.RealI2 val) : base(val)
			{

			}


			



		}

	}
}
