using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.duo.comparer_
{
	public class ByX : ComparerI
	{
		public int Compare(Duo x, Duo y)
		{
			return nilnul.num.ieee.Comparer.Lazy.Compare(x.Item1, y.Item1);

			//throw new NotImplementedException();
		}


		static private Lazy<ByX> _Lazy = new Lazy<ByX>();
		static public ByX Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
