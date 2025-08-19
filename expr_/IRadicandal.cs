using System;

namespace nilnul.num.real.expr_
{
	///math.stackexchange.com/questions/1073653/what-is-the-difference-between-algebraic-expressions-and-polynomials
	///
	/// "Algebraic expression" is not a precisely defined term. Algebraic expressions include many things that are not polynomials, including rational funtions, which come from dividing polynomials, and things like √x
	///
	///
	/// en.wikipedia.org/wiki/Algebraic_expression
	/// an expression built up from constants (usually, algebraic numbers), variables, and the basic algebraic operations: addition (+), subtraction (-), multiplication (×), division (÷), whole number powers, and roots (fractional powers)
	///
	///
	///  note: the root of polynomial might be not <see cref="IRadicandal"/>, but shall be <see cref="IAnalytic"/>
	/// <summary>
	/// 	///  A solution in radicals or algebraic solution is an expression of a solution of a polynomial equation that is algebraic, that is, relies only on addition, subtraction, multiplication, division, raising to integer powers, and extraction of nth roots (square roots, cube roots, etc.
	///  eg:
	///		,root of some var or subexpr.
	/// a polynomial expression such as :
	/// 0
	/// 1
	/// 1+x
	/// x
	/// 1+x+7x^2+3x^5
	/// 3+xy^2
	///  sqrt(x)
	/// polynomial is closed in multiplication and addition.
	/// ex:
	///		sin(x) which intersects xAxis infinite times, as opposed to what a polynomial/algebraic can do;
	/// </summary>
	/// <remarks>
	/// re: <see cref="real.expr_.IRithmetic"/> which involves division;
	/// 
	/// </remarks>
	/// alias:
	///		abgebra
	///		algeaic
	///		abgeaic
	///		algebraic
	///			as this is <see cref="nilnul.obj.IAlgebra"/>
	///			,abraic
	///			,algaic
	///		polynomical
	///			only one variable, whileas polynomial involves multivariable.
	///		radicandal
	///			,where r means rational or real
	///		radicand
	///		radicash
	///		radicable
	///		
	///	vs:
	///		<see cref="real.calc_.algeaic"/> is not preferred as it lacks var here that can refer to some real in a more explicit way. for calc, the input might be a number that is not <see cref="num.real_.IAlgebraic"/>
	///

	///[Obsolete(nameof(IPolynomial)+ " is preferred; this name is reserved for algebraic function, which is the solvent of univariate polynomial equation")]
	public interface IRadicandal
		: IExpr
	{

	}



}
