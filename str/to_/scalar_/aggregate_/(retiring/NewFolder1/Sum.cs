using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str
{
	public static class _SumX
	{
		static public float Sum(float x, float y, float z) {
			return x + y + z;
		}

		static public R Sum_recur(this IEnumerable<R> x) {
			if (x.Count() == 0)
			{
				return new nilnul.num.real_.Quotient();
			}

			return nilnul.num.real.op_.binary_.Add.Singleton.op(x.First(), Sum_recur(x.Skip(1)));

		}
		static public R Sum_bisect(this IEnumerable<R> x) {
			var count = x.Count();
			
			if (count==0)
			{
				return new nilnul.num.real_.Quotient();

			}
			if (count==1)
			{
				return x.First();

			}

			var firstHalf = count / 2;
			var secondHalf = count - firstHalf;

			return nilnul.num.real.op_.binary_.Add.Singleton.op(

					Sum_bisect(x.Take(firstHalf))
					,
					Sum_bisect(x.Skip(firstHalf))
			);
			

		}



	}
}
