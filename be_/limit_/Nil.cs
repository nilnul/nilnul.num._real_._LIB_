using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.be_.limit_
{
	[DebuggerDisplay("if the argument is zero, it may return (for example, if the sequence is a quotient whose interval is set [0,0]); or it may perpetual (for example, if the sequence is 1/n)")]
	static public class _NilX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// <exception cref="">
		/// if the argument is zero, it may return (for example, if the sequence is a quotient whose interval is set [0,0]); or it may perpetual (for example, if the sequence is 1/n)
		/// if the argumentis not zero, it always return.
		/// </exception>
		/// 
		[MayPerpetual()]
		static public bool Be(A approach)
		{
#warning may perpetual if the argument is converging zero like 1/n
			_cauchy.approach.sign_._ofLimit.Trans.Void(approach);
			return approach.range.containsZero();
		}
	}
}