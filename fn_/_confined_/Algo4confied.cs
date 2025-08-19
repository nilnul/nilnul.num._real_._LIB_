using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_._confined_
{
	/// <summary>
	/// the algorithm if the input is in <see cref="IConfine"/>;
	/// Hence, the <see cref="fn"/> has to wrap this as:
	///		if confined, algo4confined.
	///		else, throw exception.
	/// </summary>
	public interface Algo4confinedI
	{
		double _op_0confined(double x);
	}
}
