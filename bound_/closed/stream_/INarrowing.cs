using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.stream_
{
	/// <summary>
	/// the diameter of the bound is decreasing;
	/// note: this might be nonnested, so it might be not convergent as indicated by eg:
	///		0,1,2,3,...
	///		1,1/2,1/4,
	///		1,-1,1,-1
	///     we have:
	///			1*   (0 + [-1,1]  )
	///			, -1 * (1+[-1/2, 1/2] )
	///			,
	///			2+[-1/4, 1/4]
	///			,
	///			-3 + [-1/8, 1/8]
	/// 
	/// </summary>
	public interface INarrowing
		:INonwidening
	{
	}

}
