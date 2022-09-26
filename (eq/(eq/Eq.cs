using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.dbl
{
	public class Eq
		:IEqualityComparer<double>
	{
		

		

		public bool Equals(double x, double y)
		{
			return x==y;
		}

		public int GetHashCode(double obj)
		{
			return obj.GetHashCode();
		}

		static public Eq Lazy
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Eq>.Instance;
			}
		}


	}
}
