using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;
using nilnul.num._real.approach;

namespace nilnul.num.real_
{
	/// <summary>
	/// a single (not a set) of generator
	/// </summary>
	public class Singleton : RealI2
	{
		private _real.approach.GeneratorI _approach;

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
				//throw new NotImplementedException();
			}
		}

		
	}

	static public class SingletonX {
		static public Singleton ToSingleton(this GeneratorI limit) {
			return new Singleton(limit);
		}

	}
}
