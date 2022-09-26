using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.interval
{
	public class Eq
		:
		SingletonByDefaultNew<Eq>
		,
		
		IEqualityComparer<Interval3>
	{
		public bool Equals(Interval3 x, Interval3 y)
		{
			return nilnul.order.bound.Eq_comparerDefault<_ext.ExtI, ext.Eq, ext.Bound>.Singleton.Equals(x.lower, y.lower) && nilnul.order.bound.Eq_comparerDefault<_ext.ExtI, ext.Eq, ext.Bound>.Singleton.Equals(x.upper, y.upper);

			throw new NotImplementedException();
		}

		public int GetHashCode(Interval3 obj)
		{

			throw new NotImplementedException();
		}
	}
}
