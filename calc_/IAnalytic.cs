namespace nilnul.num.real.calc_
{
	/// <summary>
	/// algebraic, but also 
	/// involving convergent power series, which is in general infinite.
	/// eg:
	///		ln
	///		exp
	///		polyadic, x^a, where a is rational
	///		pow(x,y)
	///		
	/// </summary>
	/// <remarks>
	/// e^ix= cos(x) + i sin(x)
	/// e^(-ix) = cos(x) -i sin(x)
	/// hence:
	///		cos(x) = (e^ix + e^-ix) /2.
	///		
	/// </remarks>
	/// alias:
	///		elementary
	///		rudimental
	///		closed form
	public interface IAnalytic:real.ICalculation
	{
	}



}
