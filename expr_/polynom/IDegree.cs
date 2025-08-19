using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom
{
	/// <summary>
	/// regard polynom as :
	///		Sigma(0 to inf), a[i] X^i,    and a[i] is 0 since some terms.
	///		, then the degree is the supremum of the degrees of each nonnil monomial.
	///	;
	///	for <see cref="polynom_.INegligible"/>, the degree is the maximum of empty set, which is <see cref="num.real.xt.bi_.max._cumula_.INeutral"/> which is -inf
	///		
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// alias:
	///		order, archaic, now refers to other thing;
	///		valency
	///	vs:
	///		arity, ending in "-ary", based on Latin distributive number (<see cref="polynom_.IBivariate"/>, or binary); while degree term such as quadratic ends in "-ic", based on Latin;
	public interface IDegree:IXpn
	{
	}
}
