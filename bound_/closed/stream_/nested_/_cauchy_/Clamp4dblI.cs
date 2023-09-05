using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.stream_.nested_._cauchy_
{
	/// <see cref="num.quotient.bound_.closed.stream_.slider_.nested_._cauchy_.ClampI"/>
	/// <see cref="num._real_.ClampI1"/>
	/// <summary>
	/// 
	/// </summary>
	public interface Clamp4dblI
		//:
		//nilnul.num.quotient.bound_.closed.stream_.nested_._cauchy_.ClampI1
	{
		/// <summary>
		/// the current and all the following bound would be of a diameter le the <paramref name="diameter"/>;
		/// </summary>
		/// <param name="diameter"></param>
		void clamp(nilnul.num.real_.PositiveDblI diameter);

	}
}
