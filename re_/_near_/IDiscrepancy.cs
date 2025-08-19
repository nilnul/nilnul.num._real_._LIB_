using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.re_._near_
{

	/// <summary>
	/// for a given set of reals, this can still form an equiv relation if reals are clustered with respect to nearness:
	///		,near reals are clustered, near to each other
	///		,apart reals are apart, not near to each other. 
	/// </summary>
	/// <remarks>
	/// le, not lt, is used in <see cref="re_.INear"/> to allow 0 as discrepancy.
	/// </remarks>
	/// alias:
	///		distance
	public interface IDiscrepancy:real_.IUnnegative
	{
	}
}
