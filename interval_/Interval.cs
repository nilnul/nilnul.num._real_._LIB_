using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.ext.border;

using R = nilnul.num.RealI;

namespace nilnul.num.real.ext
{
	/// <summary>
	/// bound
	/// </summary>
	public class Interval

		: nilnul.be.Asserted_assertDefaultDiscarded<
			border.Duo, border.duo.be_.Interval
			>
	{
		public Interval(border.Duo val) : base(val)
		{
		}

		static public Interval CreateLeftCloseRightInf(R x) {
			return new Interval(
				new border.Duo(
						new Border(true, new ext_.Bare(x))
						,
						new Border(false,ext_.inf_.Pos.Singleton)
					)	
			);
		}


	}
}
