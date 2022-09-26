using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.limit.be
{

	[DebuggerDisplay("if the argument is zero, it may return (for example, if the sequence is a quotient whose interval is set [0,0]); or it may perpetual (for example, if the sequence is 1/n)")]

	public class Zero
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

		static public bool Eval(real.RealI_posConverge2NonEmpty real)
		{
			#warning may perpetual if the argument is converging zero like 1/n
			while (real.interval.containsZero())
			{

				if (real.interval.isSingleton())
				{
					return true;

				}

				real.converge(new num.rational.be.Positive.Asserted(real.interval.span / 2));

			}

			return false;


		}

	}
}
