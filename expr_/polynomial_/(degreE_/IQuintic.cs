using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num.real.expr_.polynomial_
{

	/// <summary>
	/// coefficient of the last (withthe highest degree) is nonnil
	/// </summary>
	/// <remarks>
	/// the degree is five. 
	/// a*x^5 + b*x^4 + c*x^3 + d*x^2+e*x +f, where a is not nil;
	/// </remarks>
	/// 
	interface IQuintic
		: IPolynomial
	{
	}
}

