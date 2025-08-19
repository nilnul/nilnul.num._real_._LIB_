using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class Positive
		:
		nilnul.num.real.BeI
		,
		nilnul.num.real.BeI_onQuoient

	{

		[MayPerpetual]
		public bool be(num.RealI real)
		{
			while (true)
			{
				if (
					real.current.upper.mark<=0
				)
				{
					return false;

				}
				if (
					
						real.current.lower.mark>0
					
				)
				{
					return true;
				}
				// upper > 0, lower <=0
				//
				
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
					real.current.end<=0
				)
				{
					return false;

				}
				if (
					
						real.current.begin>0
					
				)
				{
					return true;
				}
				// upper > 0, lower <=0
				//
				
				real.CinchHalf();

			}
			//throw new NotImplementedException();
		}


		static public Positive Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Positive>.Instance;
			}
		}


	}
}
