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
	public  class SignOfTerminalTerms
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// 

		
		[MayPerpetual]
		static public void Clamp2AlignSign(ApproachI1 real) {

			while (real.bound.containsZero())
			{

				if ( real.bound.isSingleton)
				{
					return;
					
				}

				real.Clamp1K();
				
			}

			

		}


		[MayPerpetual]
		static public int Eval(ApproachI1 real) {
			var range = real.bound;

			while (real.bound.containsZero())
			{

				if ( real.bound.isSingleton)
				{
					return 0;
					
				}

				real.Clamp1K();
				
			}

			return nilnul.num.quotient.Comparer1.lazy.sign(
				real.bound.midPoint	///don't user lower or upper for they may be zero.
				
					
			);

		}



		



	}
}
