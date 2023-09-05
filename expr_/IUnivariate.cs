namespace nilnul.num.real.expr_
{
	/// <summary>
	/// with only one variable;
	/// eg:
	///		3x
	///		x^3
	///		2x^2
	/// </summary>
	/// <remarks>
	/// ambiguity about
	///		x^0
	///		1
	///		3*1
	///		3*x^0
	///		0*x
	///		0^x^6
	///		we intend to include any with one and one variable, no matter what the indic or the coefficient is;
	/// </remarks>
	public interface IUnivariate { }
}
