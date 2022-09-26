using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_.pow_
{
	static public class _IndexX
	{
		//static public nilnul.num.RealI RealI(nilnul.num.RealI basis, BigInteger sup) {
		//	if (sup>=0)
		//	{
		//		return op_.unary_._IndexX.RetRealI(basis, sup);
		//	}
		//}
	}

	/// <summary>
	/// for a real number, x, we compute x^i, where i is integer.
	/// 
	/// </summary>
	/// <remarks>
	/// the i is also the initial of:
	///		integer,
	///		inverse, as x^-2=1/x^2
	///	alias:
	///		raisal
	///		ration
	/// </remarks>
	interface IndexI:PowI
	{
	}
}
