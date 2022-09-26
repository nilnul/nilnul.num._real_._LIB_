using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.centered_
{
	static public class _AcuteDblX
	{
		static public real.BoundDbl Neighbor = _CreateOpen();
		static public real.BoundDbl _CreateOpen() {
			return bound_._CenteredDblX.CenterNilOpen_ofRadius(
				
					nilnul.num.real_.TauX.QuarterD
				
			);
  }
	}
}
