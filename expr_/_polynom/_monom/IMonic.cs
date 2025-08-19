using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._polynomial._monomial
{
	/// <summary>
	/// no coef; that means the coef is explictly 1;
	/// </summary>
	/// <remarks>
	/// any polynomial is a linear combination of this.
	/// 
	/// When studying the structure of polynomials however, one often definitely needs a notion with the meaning. This is for instance the case when considering a monomial basis of a polynomial ring, or a monomial ordering of that basis. An argument in favor of the meaning is that no obvious other notion is available to designate these values, though primitive monomial is in use and does make the absence of constants clear
	/// </remarks>
	/// alias:
	///		mononomial
	///		monic
	///		basis
	///		primitive
	public interface IMonic
	{
	}
}
