using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext.bound
{
	public class CompareLower : IComparer<Bound>
	{
		static public CompareLower Singleton = SingletonByDefault<CompareLower>.Instance;
		public int Compare(Bound x, Bound y)
		{
			return nilnul.order.comparer.bound.comparer.Lower_elementComparerDefault<_ext.ExtI, ext.Ord, Bound>.Singleton.Compare(x, y);
			throw new NotImplementedException();
		}
	}
}
