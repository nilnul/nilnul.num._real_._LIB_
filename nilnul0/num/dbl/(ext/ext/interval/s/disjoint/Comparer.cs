using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.interval.s.disjoint
{
	public class Comparer
		: IComparer<Interval3>
	{
		public int Compare(Interval3 x, Interval3 y)
		{
			return ext.bound.CompareLower.Singleton.Compare(x.lower, y.lower);

			throw new NotImplementedException();
		}
	}
}
