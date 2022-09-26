using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.be_.limit_
{
	/// <summary>
	/// limit is not zero
	/// </summary>
	public class Nonnil : BeI
	{


		[MayPerpetual]
		public bool be(A approach)
		{
#warning may perpetual if the argument is converging zero like 1/n

			_cauchy.approach.sign_._ofLimit.Trans.Void(approach);

			return approach.range.notContainsZero();
		}

		

		static public Nonnil Singleton
		{
			get
			{
				return nilnul.Singleton1<Nonnil>.Instance;
			}
		}
	}
}