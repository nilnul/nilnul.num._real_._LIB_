namespace nilnul.num.real.expr_
{
	/// <see cref="real.calc_.IAnalytic"/>
	/// This contrasts with numerical solutions, which approximate the answer through computation/simulation/sampling/ai, or graphical solutions, which rely on visual interpretation.
	///
	/// <summary>
	/// can be expressed as <see cref="real.fn_.IAnalytic"/>
	/// ;
	/// eg:
	///		<see cref="IRadicandal"/>
	///		e^x
	///			ln(x)
	///		trignometric such as: cos(x)
	///		,
	///		special:
	///			gamma
	///	ex:
	///		shuffling
	///		combinatorics
	///		numerical method
	///		
	///		
	/// </summary>
	/// <remarks>
	/// 	 note: the root of polynomial might be not <see cref="IRadicandal"/>, but shall be <see cref="IAnalytic"/>, as we can numerically solve that recursively
	/// 	 ;
	/// 	 
	/// </remarks>
	///
	/// 
	/// this is a powerful definition that covers many cases. every real number can be expressed as a position notation form, which is effectively a power series. But a functional power series tackles not a single real number, but a collective of real numbers, regarding them as a related connected clan, allowing an algorithm to tackle more than an isolated real number.
	/// 
	/// this demonstrates the necessity of the definition of <see cref="IExpr"/>, which uses vars to denote the members of a finite set, avoiding ambiguity of whether the denoted values are <see cref="num.real_.IAlgebraic"/> or <see cref="num.real_.ITranscendental"/>. 
	public interface IAnalytic
		: IExpr
	{
	}


}
