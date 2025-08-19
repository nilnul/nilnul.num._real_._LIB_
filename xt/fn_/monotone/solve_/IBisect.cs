using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.xt.fn_.monotone.solve_
{

	/// <summary>
	/// utilize accelerate search for radiate domain (<see cref="fn_.confined_.radiate_.strict._solve_"/>), utilize binary search for confined domain, <see cref="real.fn_.confined_.grow.solve_._BinarySearchX"/>
	/// vs:
	///		<see cref="real.func_.unary_.monotone.invert_.search_.IBisect"/>, here we can easily have an initial closed bound;
	///		but if one border is inf, the mid point might be still inf, incident to the original inf border, failing to narrow the bound. So here we still need a nonbisect search such as <see cref="IExponential"/>
	/// </summary>
	///

	internal class IBisect
	{
	}
}
