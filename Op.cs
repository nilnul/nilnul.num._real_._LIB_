using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// a function the return type of which is Real, including:
	///		binary op, which is tuple_.binary -> real.
	///		construct which returns real but takes in any type.
	/// </summary>
	public interface OpI : nilnul.obj._op_.RetI<nilnul.num.RealI>
	{
	}

	public interface Op4dblI
		: nilnul.obj.OpI3<double>
	{

	}
}
