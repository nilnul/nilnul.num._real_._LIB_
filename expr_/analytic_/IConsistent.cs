namespace nilnul.num.real.expr_.analytic_
{
	/// consistent converge from algebraic function.
	///
	/// <summary>
	/// the power series uniformly converge
	/// </summary>
	///
	/// 
	/// ln(x) = ln( (1+y) / (1-y))
	///		,where y = (x-1)/(x+1)
	public interface IConsistent:IAnalytic { }

}
