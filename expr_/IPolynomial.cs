﻿namespace nilnul.num.real.expr_
{
	/// <summary>
	/// a polynomial expression such as :
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
	/// <remarks>
	/// univariate or constant or nil;
	/// </remarks>
	/// alias:
	///		algebraic
	public interface IPolynomial
		: IExpr
	{

	}
}
