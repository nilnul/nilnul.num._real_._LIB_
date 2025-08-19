using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.pred_.simult.slv_
{
	/// <summary>
	/// permutate the constraints such that explicate ones are put forward.
	/// eg:
	///		{
	///			(x-1)x   =0
	///			,
	///			x!=0
	///		}
	///			,which is demoted from {  x^2 (x-1) / x =0   }
	///		, is shuffled to:
	///		{
	///			x!=0
	///			(x-1)x =0
	///		}
	/// </summary>
	public interface IShuffle:simult.ISolve
	{
	}
}
