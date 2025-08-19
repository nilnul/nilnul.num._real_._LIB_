namespace nilnul.num.real.expr_
{
	/// <summary>
	/// involving only one single var as in <see cref="IPolynomial"/>;
	/// only one term;
	/// with no coefficient.
	/// eg:
	///		x3, which means x^3, not 3x, which means 3*x, nor x[3]
	///		
	/// </summary>
	/// <remarks>
	/// a miniature <see cref="IPonent"/>
	/// </remarks>
	/// alias:
	///		poly
	///		pol
	///		ponent
	///		pow
	public interface IPonent:expr_.IUnivariate { }
}
