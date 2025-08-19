using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_
{
	/// <summary>
	/// eg:
	///		a^2+ b^2 ==0? throw new Exception(): 1/(a^2+b^2)
	///	;
	///	eg:
	///		x ==0? throw new DivideByNil Exception(): 1/x
	///		, where x ==0 maps x the real number, , into a subset {0,1}
	/// </summary>
	/// <remarks>
	/// this is useful when symbol computating of complex/quaternion algebra.
	/// </remarks>
	/// alias:
	///		case by case
	///		a union of <see cref="IConstrained"/>, where the union of the premise is the premise of this.
	internal class IConditional
	{
	}

}
