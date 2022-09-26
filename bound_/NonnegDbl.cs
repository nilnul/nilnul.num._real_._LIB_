using nilnul.num.real._bound;
using nilnul.num.real.border;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_
{
	public class NonnegDbl : BoundDbl
	{
		

		public NonnegDbl(border.AsUpperDbl y) : base( border.lower_.ClosedDbl.Singleton , y)
		{
		}

	

		public NonnegDbl( BorderDbl borderDbl2) : this(new AsUpperDbl(borderDbl2))
		{
		}
	}
}
