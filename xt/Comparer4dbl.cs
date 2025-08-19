using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext
{
	public class Comparer4dbl : IComparer<Ext4dblI>
	{
		public int Compare(Ext4dblI x, Ext4dblI y)
		{
			return x.errable.CompareTo(y.errable);
		}



		static public Comparer4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer4dbl>.Instance;
			}
		}


	}
}
