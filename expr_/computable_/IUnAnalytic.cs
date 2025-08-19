using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.computable_
{
	/// <summary>
	/// numerical method. not power series.
	/// note: computable means the form/formula of the expr, or the process of the function. not the result.
	/// for a numerical method, the result might be also solvable by simpler algebraic method.
	/// </summary>
	/// <remarks>
	/// eg：
	///		integration of monotonic function calculated by numerical method.
	///	eg:
	///		solved by simulation, artificial neuro network, genetic algorithm, simulated annealing algorithm, ...
	/// </remarks>
	public interface IUnAnalytic:IComputable
	{
	}
}
