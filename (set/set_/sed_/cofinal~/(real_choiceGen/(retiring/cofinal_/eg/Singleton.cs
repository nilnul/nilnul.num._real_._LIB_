using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;

namespace nilnul.num._real.approach.generator.cofinal.eg
{
	public class Singleton : CofinalI
	{
		private GeneratorI _approach;

		public GeneratorI approach
		{
			get { return _approach; }
			set { _approach = value; }
		}

		public Singleton(GeneratorI approach)
		{
			_approach = approach;

		}

		

		//public Singleton(Q q):this(new generator.eg.Quotient(q))
		//{

		//}

		//public Singleton():this(0)
		//{

		//}


		public GeneratorI choice
		{
			get
			{
				return _approach;
				throw new NotImplementedException();
			}
		}

		
	}

	static public class SingletonX {
		static public Singleton ToSingleton(this GeneratorI limit) {
			return new Singleton(limit);
		}

	}
}
