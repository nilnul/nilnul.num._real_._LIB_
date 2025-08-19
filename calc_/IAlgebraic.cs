namespace nilnul.num.real.calc_
{
	/// <summary>
	/// besides add, mul, division, the rational pow is applied.
	/// This is the root of a <see cref="real.pred_.equat_.IPolynomial"/> (note complex root always exists), where the coef is from the prefixed set of real numbers;
	/// eg:
	///		sqrt(2)
	/// eg:
	///		pi + sqrt(e)
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// vs:
	///		<see cref="nilnul.num.real_.IAlgebraic"/> 
	/// vs:
	///		trignometric is not algebraic, as it's not the root of a polynomial
	///		An algebraic function   , must either have only finitely many zeros(real values x  such that f(x)=0  ) or must be the zero function( f(x)=0  for all x ).The trigonometric functions(sin(x) ,cos(x) ,tan(x) ) have infinitely many zeros(e.g.sin(nπ)=0  for all integers n ), but are non-zero functions. Therefore, the trigonometric functions are non-algebraic/transcendental.
	///		quora.com/How-do-you-prove-that-trigonometric-functions-are-not-algebraic
	public interface IAlgebraic:real.ICalculation
	{
	}



}
