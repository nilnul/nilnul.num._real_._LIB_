namespace nilnul.num.real.pred_
{
	/// <summary>
	///	the linear space means the linear transformation, which is essentially a finite set of vars representing axis each, is *linearly* combinated, with no nonlinear transformation such as x^2. linear transformation of X as the definition includes 0coef, as in geometry an all nil matrix is allowed.
	///	
	///	 <see cref="nilnul.num.real.pred_.simult_.ILinear"/> can have 0 count of constraints.
	/// 
	/// eg:
	///		<see cref="equal_.ILinear"/>
	///	eg:
	///		x+y >1
	///	ex:
	///		x^2
	///		1/x
	///		x+y^2
	///			
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public interface ILinear:IPred 
	{
	}





}
