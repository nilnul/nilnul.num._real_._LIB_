using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary.invert_._search
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// the initial bound might need another search before hand
	/// </remarks>
	internal enum Li_
	{
		/// <summary>
		/// <see cref="unary_.monotone.invert_.search_.IBisect"/>
		/// </summary>
		/// 
		/// alias:
		///		binary search
		Bisect
			,
		/// <summary>
		/// <see cref="unary_.convex.invert_.search_.IFibonachi"/>
		/// </summary>
		Fibonachi
			,
		/// eg: <see cref=""/>
		/// <summary>
		///  for a function that is monotone, but the scope is open like [0,+inf) (in other words, closed at <see cref="real.ext.func_.unary"/> in [0,+inf]), we search forward with a step that is two folder of previouse; and if we over reach, we backtrack and initial the <see cref="real.ext.func_.unary_.monotone.inverse_.IExponential"/> search again;
		/// </summary>
		/// alias:
		///		exponential
		///		power search
		///		geometric search
		Exponential
	}
}
