namespace nilnul.num.real.expr_.polynom_.unary_
{
	/// <summary>
	/// coefficient of the last (with the highest degree) is one
	/// eg:
	///		x^3+2x
	///		x^2
	///		x^1
	///		x^0
	///		1
	///	exclude:
	///		0 = 0*x^0
	///		3=3*x^0
	/// </summary>
	/// <remarks>
	/// it's univariate, as for plural variate, such as 3x^2 y^3 +2 x^3 y^2, we can not transform it into monic;
	/// </remarks>
	/// vs:
	///		<see cref="IMonomial"/>
	///		
	public interface IStd:polynom_.IUniVariate
	{
	}


}
