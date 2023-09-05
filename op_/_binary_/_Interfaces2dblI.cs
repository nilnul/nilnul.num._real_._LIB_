using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.of_._binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		interfaces4dbl which means using dbl as the underlying type like <see cref="real.BoundDbl"/>;
	///		interfaces2dbl which means only the returned typ is double.
	public interface _Interfaces2dblI 
	{
		double op2dbl(Real4dblI x, Real4dblI y);
	}


}
