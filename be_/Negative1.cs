using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class Negative
		: nilnul.num.real.BeI
		,
		BeI_onQuoient
	{

		[MayPerpetual]
		public bool be(num.RealI real)
		{
			while (true)
			{
				if (
					real.current.lower.mark>=0)
				{
					return false;

				}
				if (
					
						real.current.upper.mark<0
					
				)
				{
					return true;
				}
				///  lower <0,upper >= 0
				///
				
				real.Clamp1K();

			}
			//throw new NotImplementedException();
		}

		[MayPerpetual]
		public bool be(in num.RealI_onQuotient real)
		{
			while (true)
			{
				if (
					real.current.begin>=0)
				{
					return false;

				}
				if (
					
						real.current.end<0
					
				)
				{
					return true;
				}
				///  lower <0,upper >= 0
				///
				
				real.CinchHalf();

			}
			//throw new NotImplementedException();
		}

		static public Negative Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Negative>.Instance;
			}
		}


	}
}
