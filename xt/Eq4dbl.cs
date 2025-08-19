using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext
{
	public class Eq4dbl : IEqualityComparer<nilnul.num.real.Ext4dblI>
	{
		public bool Equals(Ext4dblI x, Ext4dblI y)
		{
			return x.errable == y.errable;
		}

		public int GetHashCode(Ext4dblI obj)
		{
			return obj.errable.GetHashCode();
	
		}

		static public Eq4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq4dbl>.Instance;
			}
		}



	}
}
