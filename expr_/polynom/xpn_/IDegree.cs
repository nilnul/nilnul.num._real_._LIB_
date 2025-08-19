using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.xpn_
{
	/// <summary>
	/// the coefficient of the highest ordered term;
	/// The degree of the zero polynomial 0 (which has no terms at all) is generally treated as not defined
	/// eg:
	///		3 for 4*x^3+5*x^2
	///		x^2+2, 2
	///		x^0, 0
	///		0*x^0, undef
	///		0, undef
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// alias:
	///		order, archaic, now refers to other thing;
	///	vs:
	///		arity, ending in "-ary", based on Latin distributive number (<see cref="polynom_.IBivariate"/>, or binary); while degree term such as quadratic ends in "-ic", based on Latin;
	public interface IDegree:IXpn
	{
	}
}
