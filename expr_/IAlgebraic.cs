﻿namespace nilnul.num.real.expr_
{
	/// <summary>
	/// a polynomial expression such as :
	/// 0
	/// 1
	/// 1+x
	/// x
	/// 1+x+7x^2+3x^5
	/// 3+xy^2
	/// polynomial is closed in multiplication and addition.
	/// </summary>
	/// alias:
	///		algebraic
	///			as this is <see cref="nilnul.obj.IAlgebra"/>
	///		polynomical
	///			only one variable, whileas polynomial involves multivariable.
	public interface IAlgebraic
		: IExpr
	{

	}
}
