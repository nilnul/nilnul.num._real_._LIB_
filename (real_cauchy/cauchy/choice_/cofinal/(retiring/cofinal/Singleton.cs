using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;

namespace nilnul.num._real.cofinal
{
	public class Singleton : CofinalI1
	{
		private ApproachI _approach;

		public ApproachI approach
		{
			get { return _approach; }
			set { _approach = value; }
		}

		public Singleton(ApproachI approach)
		{
			_approach = approach;

		}

		

		public Singleton(Q q):this(new approach.Quotient(q))
		{

		}

		public Singleton():this(0)
		{

		}


		public ApproachI choice
		{
			get
			{
				return _approach;
				throw new NotImplementedException();
			}
		}

		
	}

	static public class SingletonX {
		static public Singleton ToSingleton(this ApproachI limit) {
			return new Singleton(limit);
		}

	}
}
