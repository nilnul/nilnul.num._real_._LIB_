using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynomial_.poly_
{
	/// <summary>
	/// a single term;
	/// eg:
	///		x^2
	///		3x
	///		x^0
	///		3x^0
	///		2*x^0
	///		2*1
	///		2
	///		1
	///	exclude:
	///		
	///		0*x
	///		0*x^0
	///		0, as 0 is the coefficient of 0*1, and we don't count 0-coeffient terms when we define monomial, binomial, trimonial, etc;
	/// </summary>
	internal class IMonomial
	{
	}
}
