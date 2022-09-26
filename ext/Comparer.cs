using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext
{
	public class Comparer : IComparer<ExtI>
	{
		public int Compare(ExtI x, ExtI y)
		{
			if (x is ext_.inf_.Neg)
			{
				if (y is ext_.inf_.Neg)
				{
					return 0;
				}
				return -1;
			}
			if (x is ext_.Bare)
			{
				if (y is ext_.inf_.Neg)
				{
					return 1;
				}
				if (y is ext_.Bare)
				{
					return nilnul.num.real.Comparer.Singleton.Compare(
						(x as ext_.Bare).val
						,
						(y as ext_.Bare).val
					);
				}
				return -1;
			}
			if (x is ext_.inf_.Pos)
			{
				if (y is ext_.inf_.Pos)
				{
					return 0;
				}
				return 1;
			}

			throw new UnexpectedTypeException();
		}



		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}


		public class Decider : nilnul.comparer.decider_.FroStatic1<ExtI, Comparer>
		{

			static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;

		}
	}
}
