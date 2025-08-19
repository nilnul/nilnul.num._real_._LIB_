using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.comparer_
{
	public class Lower : IComparer<Border>
	{
		public int Compare(Border x, Border y)
		{
			var markCompared = nilnul.num.real.ext.Comparer.Singleton.Compare(x.mark, y.mark);

			if (markCompared == 0)
			{
				return nilnul.border._comparer.Lower.CompareOpenFalse(x.openFalseCloseTrue, y.openFalseCloseTrue);
			}
			return nilnul.num.real.ext.Comparer.Singleton.Compare(x.mark, y.mark);

			throw new NotImplementedException();
		}



		public class Decider : nilnul.comparer.decider_.FroStatic1<Border, Lower>
		{
			static public bool Contains(Border x, ExtI y)
			{
				return Singleton.le(x, Border.CreateClose(y));
			}
			static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;


		}
	}
}
