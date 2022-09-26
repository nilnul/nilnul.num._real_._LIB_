using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator.be;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	[Obsolete()]

	public class Negative
		: nilnul.num.real.BeI
	{
		public bool be(num.RealI2 obj)
		{
			return  nilnul.num._real.approach.generator.be_.Negative.Singleton.be( obj.choice);

			//throw new NotImplementedException();
		}

		static public readonly Negative Singleton = SingletonByDefault<Negative>.Instance;

		public class Aver:nilnul.num.real.be.Aver<Negative>
			
		{


			static public readonly Aver Singleton = SingletonByDefault<Aver>.Instance;


		}

		public class En : be.En<Negative>
		{

			public En(Dec radius_q)
				:this( new num.real_.Quotient(radius_q))
			{
			}

			public En(num.RealI2 val) : base(val)
			{

			}


			



		}

	}
}
