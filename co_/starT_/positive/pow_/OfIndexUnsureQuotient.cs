using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q = nilnul.num.QuotientI;
using R = nilnul.num.RealI;//.R;//.RealI;


namespace nilnul.num.real.co_.starT_.positive.pow_
{
	/// <summary>
	/// 0^-1 is exception
	/// </summary>
	/// <remarks>
	///		Pow(x,y), or x^y, is defined as e^yln(x). So e^x, or op_.Exp must be defined beforehand; that's why we have another operator, op_.Exp, whereas Exp is reserved as an unary operator, which takes e as the radicand<c><see cref="nameof(approach.op_.exp)"/></c>
	///		Cuz x^y is defined as x^ln(y):
	///			1) x >0
	///			2) the result is a single value. we don't have -1 as the result of 1^(1/2). This normalizes(simplifies) the operation. And if you need complexity to have multiple roots, we can extend this op and define another op. Remember our design principals: if part of things can be peeled off into a lower-complex level, divide it; never promote complexity, by merging.
	///			3) due to the above two specification, thank mother Nature, y can be any value negative, 0, or positive. we'll not run into abnormaties.
	/// </remarks>
	static  class _OfIndexMayIrrationalX
	{

	


		
	}
}
