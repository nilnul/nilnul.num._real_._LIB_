namespace nilnul.num.real.expr_
{
	/// <summary>
	/// on condition that.
	/// eg:
	///		an expression 1/x, and the premise is preset in advance as x!=0
	///
	/// ; outside the constraint, the val is interpretated as xpn;
	/// </summary>
	/// <remarks>
	/// <see cref="nilnul.optim"/> contains a target function which is an expr, and the constraints are <see cref="real.pred_.ISimulty"/>
	/// </remarks>
	/// alias:
	///		contextual
	///		premised
	public interface IConstrained:IExpr
	{
	}



}
