using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieeeF
{
	public class Comparer : IComparer<float>
	{
		public int Compare(float x, float y)
		{
			return x.CompareTo(y);
			//throw new NotImplementedException();
		}

		static private Lazy<Comparer> _Lazy = new Lazy<Comparer>();
		static public Comparer Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
