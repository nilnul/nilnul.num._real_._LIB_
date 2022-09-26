using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.double_.b;
using NoNaN = nilnul.num.real.double_.b.NoNaN.Asserted;

namespace nilnul.num.real.double_.noNaN
{
	public class Comparer : IComparer<NoNaN>
	{
		public int Compare(NoNaN x, NoNaN y)
		{
			return x.val.CompareTo(y.val);
			throw new NotImplementedException();
		}
	}
}
