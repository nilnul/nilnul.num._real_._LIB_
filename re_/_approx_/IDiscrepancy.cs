using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.re_._approx_
{

	/// <summary>
	/// for a given set of reals, this can still form an equiv relation if reals are clustered with respect to approximation:
	///		,approx reals are clustered, approximate to each other
	///		,unapprox reals are apart, not approximated to each other. 
	/// </summary>
	/// <remarks>
	/// le, not lt, is used in <see cref="re_.IApproximate"/> to allow 0 as discrepancy.
	/// </remarks>
	public interface IDiscrepancy:real_.IUnnegative
	{
	}
}
