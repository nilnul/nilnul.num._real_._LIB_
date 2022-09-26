using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.limit.cofinal
{
	public class Singleton : ConfluentI
	{
		private LimitI _limit;

		public LimitI limit
		{
			get { return _limit; }
			set { _limit = value; }
		}

		public Singleton(LimitI limit)
		{
			_limit = limit;

		}

		public Singleton(Q q):this(new limit.Quotient(q))
		{

		}

		public LimitI choice
		{
			get
			{
				return _limit;
				throw new NotImplementedException();
			}
		}

	}

	static public class SingletonX {
		static public Singleton ToSingleton(this LimitI limit) {
			return new Singleton(limit);
		}

	}
}
