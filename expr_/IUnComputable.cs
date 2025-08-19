namespace nilnul.num.real.expr_
{
	/// <summary>
	/// eg:
	///		Goldbach conjecture is true?0:1
	///			is a number, but currently goldbach is semidecidable( by enumerating to a certain extent, if we find a counterexample, then it's solved; but if we cannot, we don't know the answer.)
	///	eg:
	///		Riemman conjecture is true?0:1
	///			, is a real number, but currently it's undecidable (there is no way to enumerate all reals, and computer program is, over time, a discrete number of steps, hence we cannot solve that.)
	///	;
	///	eg:
	///		other real number we can prove exist, but cannot construct.
	/// </summary>
	public interface IUnComputable
		: IExpr
	{
	}


}
