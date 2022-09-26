using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI;

namespace nilnul.num.real._sign
{
	[MayPerpetual]
	static public  class _TrichotomyX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// 
		[MayPerpetual]
		static public void Void(R real) {
			//var bound = real.bound;

			while (real.current.containsZero())
			{
				if ( real.current.isSingleton)
				{
					return;// real;
				}
				real.Clamp1K();
			}

			while (real.current.lower.mark==0 || real.current.upper.mark==0)
			{
				real.Clamp1K();
			}
		}
	}
}
