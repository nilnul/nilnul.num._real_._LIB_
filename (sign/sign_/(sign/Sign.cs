using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._real.approach;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach
{
	[MayPerpetual]
	static public  class _SignX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// 
		[MayPerpetual]
		static public void _Clamp(ApproachI1 real) {
			//var range = real.bound;

			while (real.bound.containsZero())
			{

				if ( real.bound.isSingleton)
				{
					return;// real;
					
				}

				real.Clamp1K();
				
			}


			while (real.bound.lower.mark==0 || real.bound.upper.mark==0)
			{

				real.Clamp1K();

			}

		}

		
		[MayPerpetual]
		static public bool? Sign(ApproachI1 real) {

			_Clamp(real);
			return nilnul.num.quotient._SignX.Sign(
				( nilnul.num.Quotient)( real.bound.lower.mark )
			);

		}



	

		




	}
}
