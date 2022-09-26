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
	[Obsolete("this shall be closed: "+nameof(num.quotient.bound_.closed.stream_._slider_.CurrentI))]
	public interface BoundI
		//:
		//nilnul.num.quotient.stream_._bounded_.BoundI	//better use closed ones
	{
		/// <summary>
		/// the real must be in the bound.
		/// so the meaning is different from the bound of a quotient stream
		/// for a stream such as (0,1/n), the bound shall be [0,1/n] as the limit is not in (0,1/n).
		/// Due to the fact that real can falls on the openBorder, the bound shall be closed in that case. That's whey nestedInterval definition only considers closed interval.
		/// 
		/// </summary>
		/// <remarks>
		/// in some cases, such as when the number is irrational, the bound is open as we know number cannot be on border
		/// for quotient cauchy, the limit may be on the border, outside, the elements's bound 
		/// </remarks>
		nilnul.num.quotient.Bound current { get; }
	}
}
