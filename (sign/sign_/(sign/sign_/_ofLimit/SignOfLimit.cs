using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._real.approach;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.sign_._ofLimit
{
	[MayPerpetual]
	static public  class Trans
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// 
		[MayPerpetual]
		static public void Void(A real) {
			//var range = real.bound;

			while (real.range.containsZero())
			{

				if ( real.range.isSingleton)
				{
					return;// real;
					
				}

				real.Clamp1K();
				
			}


			while (real.range.lower.mark==0 || real.range.upper.mark==0)
			{

				real.Clamp1K();

			}

		}

	

	




	}
}
