using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound
{
	public class LowerUpper
		: nilnul.obj._bound.LowerUpperA<RealI, Lower, Upper>
	{
		public LowerUpper(Lower lower, Upper upper) : base(lower, upper)
		{
		}
	}
}
