using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real
{
	/// <summary>
	/// squeeze from an approach to appraoch to a limit.
	/// <see cref="nameof(nilnul.num.quotient.stream_.convergent.ConvergingI)"/>
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.num.quotient.stream_._cauchy_.ApproachI))]
	public interface ApproachI1
		:_approach.members.BoundI
	{
		void clamp(nilnul.num.quotient.be_.Positive1.En diameter);
	}

	public static class ApproachX
	{

		public static void ConvergeHalf(this ApproachI1 r)
		{
			if (r.bound.diameter !=0)
			{
				r.clamp(

					new quotient.be_.Positive1.En(
						r.bound.diameter.toHalf()

					)
				);

			}



		}

		[MayPerpetual()]
		[Obsolete("",true)]
		public static int Sign(this ApproachI1 approach)
		{

			return _real.approach.SignOfLimit.Eval(approach);

			//while (approach.bound.containsZero())
			//{
			//	if (approach.bound.isSingleton)
			//	{
			//		return 0;
			//	}
			//	else
			//	{
			//		_real.ApproachX.ConvergeHalf(approach);

			//	}

			//}

			//return nilnul.num.quotient.Comparer1.lazy.Compare(

			//	approach.bound.
			//	lower.mark
			//	//midPoint

			//	, 0);


		}


	}
}
