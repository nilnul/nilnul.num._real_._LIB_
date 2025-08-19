using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real
{
	public class EqDbl
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


		static public EqDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EqDbl>.Instance;
			}
		}



	}
}
