namespace nilnul.num.real.expr_
{
	///en.wikipedia.org/wiki/Polynomial
	///
	/// 
	/// <summary>
	/// involves only the operations of addition, subtraction, multiplication and exponentiation to nonnegative integer powers, and has a finite number of terms. An example of a polynomial of a single indeterminate x is x2 − 4x + 7. An example with three indeterminates is x3 + 2xyz2 − yz + 1.
	/// , where when integer is written after a var, it's interpreted as pow. 
	/// 0
	/// 0*x^0
	/// 2*x^0
	/// 2
	/// 1
	/// 1+x
	/// x
	/// 1+x+7x^2+3x^5
	/// 3+xy^2
	/// polynomial is closed in multiplication and addition.
	/// </summary>
	///
	/// 
	/// <remarks>
	/// univariate or constant or nil;
	/// we may also allow multiple variables
	/// </remarks>
	/// 
	/// alias:
	///		algebraic <see cref="expr_.IRadicandal"/>
	public interface IPolynomial
		: IExpr
	{

	}


}
