namespace nilnul.num.real.calc_
{
	/// <summary>
	/// given a finite set of reals, apply preknown finite set of operations in finite steps.
	/// include:
	///		+-*/
	///		pol: x^3,x^(-1), x^ (-1/2) , x^ e
	///		
	///		exp: e^x,  a^x = e^ (x ln(a) )
	///		ln, log: log(a,x) = ln(x) /ln(a)
	///		
	///		pow: e^pi, which is e ^(pi ln(e) )
	///		
	///		
	/// </summary>
	/// alias:
	///		constructible.
	///		conceivable
	///		closedForm
	///		complex
	///		wellFormed
	///	vs:
	///		rudimental
	///		elementary
	///		arithmetic
	///		<see cref="IAnalytic"/>
	///		
	/// 
	interface IConceivable:real.ICalculation
	{
	}


}
