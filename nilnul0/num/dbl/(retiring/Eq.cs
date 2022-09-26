using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.doubl
{
	public partial class Eq
		:IEqualityComparer<double>
	{
		

		

		public bool Equals(double x, double y)
		{
			return x==y;

			throw new NotImplementedException();
		}

		public int GetHashCode(double obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}

		static public Eq Singleton = SingletonByDefault<Eq>.Instance;
	}
}
