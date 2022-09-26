using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound
{
	public class LowerUpperDbl
		: nilnul.obj._bound.LowerUpperA<double, LowerDbl, UpperDbl>
	{
		public LowerUpperDbl(LowerDbl lower, UpperDbl upper) : base(lower, upper)
		{
		}
	}
}
