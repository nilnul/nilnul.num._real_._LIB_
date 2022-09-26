using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.centered_
{
	public class Acute
	{
		static public real.Bound Neighbor = _CreateOpen();
		static public real.Bound _CreateOpen() {
			return bound_._CenteredX.CenterNilOpen_ofRadius(
				
					nilnul.num.real_.TauX.Quarter
				
			);
  }
	}
}
