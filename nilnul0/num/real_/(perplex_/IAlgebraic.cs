namespace nilnul.num.real_
{
	/// <summary>
	/// besides add, mul, division, the rational pow is applied, on natural numbers.
	/// This is the root of a <see cref="real.pred_.equat_.IPolynomial"/> (note complex root always exists), where the coef is from the prefixed set of rational numbers;
	/// eg:
	///		 sqrt(2/3)
	/// </summary>
	/// <remarks>
	///Algebraic complex numbers are closed under addition, subtraction, multiplication and division, and hence form a field.
	///The set of algebraic real numbers  is also a field.There are countably many algebraic numbers, hence almost all real (or complex) numbers (in the sense of Lebesgue measure) are transcendental.
	/// </remarks>
	/// vs:
	///		<see cref="nilnul.num.real.calc_.IAlgebraic"/>, where a finite set of reals (rather than natural numbers) are applied the algebraic calculation: n-th root.
	/// vs:
	///		trignometric
	public interface IAlgebraic:num.IReal
	{
	}




}
