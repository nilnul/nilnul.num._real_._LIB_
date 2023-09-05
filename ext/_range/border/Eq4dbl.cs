using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border
{
	public class Eq4dbl
		:
		IEqualityComparer<nilnul.num.real.ext.Border4dblI>
		,
		IEqualityComparer<nilnul.num.real.ext.Border4dbl>

	{
		public bool Equals(Border4dblI x, Border4dblI y)
		{
			return (x.openFalseCloseTrue == y.openFalseCloseTrue) && ext.Eq4dbl.Singleton.Equals(x.mark,y.mark);
		}

		public int GetHashCode(Border4dblI x)
		{
			return (x.openFalseCloseTrue.GetHashCode()) & ext.Eq4dbl.Singleton.GetHashCode(x.mark);

		}

		public bool Equals(Border4dbl x, Border4dbl y)
		{
			return Equals((Border4dblI)x, (Border4dblI)y);
		}

		public int GetHashCode(Border4dbl x)
		{
			return GetHashCode((Border4dblI)x);

		}

		public bool eq(Border4dblI item1, Ext4dblI negInf)
		{
			return Equals(item1,  Border4dbl.CreateClose( negInf));
		}

		static public Eq4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq4dbl>.Instance;
			}
		}

	}
}
