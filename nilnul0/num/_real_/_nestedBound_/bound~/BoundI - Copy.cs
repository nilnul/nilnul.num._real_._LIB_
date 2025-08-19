using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real_
{
	/// <summary>
	/// squeeze from an approach to appraoch to a limit.The limit can be the border point, that is outside the bound if the bound is open. So this should be always taken as a closed interval.
	/// </summary>
	///
	[Obsolete(nameof(BoundI1))]
	public interface BoundI_closed
	{
		/// <summary>
		/// the real must be in the bound. for a stream such as (0,1/n), the bound shall be [0,1/n] as the limit is not in (0,1/n).
		/// Due to the fact that real can falls on the openBorder, the bound shall be closed in that case. That's whey nestedInterval definition only considers closed interval.
		/// </summary>
		nilnul.num.quotient.bound_.ClosedI bound { get; }
	}
}
