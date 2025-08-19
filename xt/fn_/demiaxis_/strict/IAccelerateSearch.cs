using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.xt.fn_.demiaxis_.strict
{
	/// <summary>
	/// double the step each time. And when overreached, backtrack by halving step.
	/// </summary>
	/// <remarks>
	/// Newton method needs derivatives, so it's deferred to a later project: nilnul.num.real._func_
	/// </remarks>
	/// vs:
	///		<see cref="xt.fn_.monotone_.strict.solve_._BisectX"/> which needs to bisect that fn first, and then use this;
	class IAccelerateSearch
    {
    }
}
