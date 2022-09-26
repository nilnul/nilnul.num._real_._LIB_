using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num._real.approachs.accumulate_
{
	public static class _SumX
	{
		

		static public ApproachI1 Sum_recur(this IEnumerable<nilnul.num._real.ApproachI1> x) {
			if (x.Count() == 0)
			{
				return new nilnul.num._real.approach_.Quotient();
			}

			return nilnul.num._real.approach.duo.op_.Add.Eval(x.First(), Sum_recur(x.Skip(1)));

		}
		static public ApproachI1 Sum_bisect(this IEnumerable<ApproachI1> x) {
			var count = x.Count();
			
			if (count==0)
			{
				return new nilnul.num._real.approach_.Quotient();

			}
			if (count==1)
			{
				return x.First();

			}

			var firstHalf = count / 2;
			var secondHalf = count - firstHalf;

			return nilnul.num._real.approach.duo.op_.Add.Eval(

					Sum_bisect(x.Take(firstHalf))
					,
					Sum_bisect(x.Skip(firstHalf))
			);
			

		}



	}
}
