using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic_
{
	/// with only one var. Note: 1, without any var, is also regarded as <see cref="IPolynomial"/>
	/// 
	/// <summary>
	/// polynomials include only variables and coefficients with mathematical operations(+, -, ×) but algebraic expressions include irrational numbers in the powers as well;
	/// eg:
	///		√(x) + 2
	///		y / (x + 1) 
	/// 
	/// 
	/// </summary>
	/// 
	public interface IPolynomial
		:IRadicandal
		,expr_.IPolynomial
	{
	}
}
