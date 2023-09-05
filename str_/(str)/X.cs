using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using Rx = nilnul.num.real.all.RealX;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.real.all
{
	[Obsolete(nameof(num.RealIX))]
	static public class X
	{

		static public R Sum(this IEnumerable<R> reals)
		{
			return (nilnul.num.real.set.to_._x._SumX.Sum_bisect(reals));
		}




	}
}
