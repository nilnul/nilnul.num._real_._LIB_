using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.conditional
{
	/// <summary>
	///  use the cartesian product to create new case, and for each case, the result is a boolean expression indicate whether the two subexpressions are euqal.
	///
	/// eg:
	/// 
	/// to compare two <see cref="IConditional"/> like:
	///		x==0? throw new DivideByNil(): 1/x
	///		,
	///		x>-1?  ln(x+1): throw new NegativeLnException()
	///	, we need:
	///		when x ==0, x> -1 compare:
	///				throw new DivideByNil()
	///				,
	///				ln(x+)
	///		when x ==0, x le -1: vacuity, no need to consider.
	///		
	///		when x!=0, x> -1 compare:
	///				1/x
	///				,
	///				 ln(x+1)
	///				
	///		when x!=0, x le -1 compare:
	///				1/x
	///				,
	///				throw new NenativeLn();
	/// </summary>
	internal class IEq
	{
	}
}
