using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co
{
	public class Comp4dbl
		:

		

		IComparer<(double, double)>
	{
		public int Compare((double, double) x, (double, double) y)
		{
			var compared4start= num.real.ComparerDbl.Singleton.Compare(x.Item1,y.Item1);
			if (compared4start == 0)
			{
				return num.real.ComparerDbl.Singleton.Compare(x.Item2, y.Item2);
			}
			return compared4start;
		}


		static public Comp4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Comp4dbl>.Instance;
			}
		}

	}
}
