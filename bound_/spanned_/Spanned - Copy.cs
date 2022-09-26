using nilnul.be.vow;
using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_
{
	

	static public class SpannedX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bound_upperInfimumGeLowerSupremum"></param>
		/// <param name="ratio"></param>
		static public void _Disengage_assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.Positive1 ratio
		) {
			var sumOfBorderRange = (bound_upperInfimumGeLowerSupremum.lower.mark.current.diameter + bound_upperInfimumGeLowerSupremum.upper.mark.current.diameter);

			if (sumOfBorderRange ==0)
			{
				return;
			}

			//var diameter = ;

			var ratio2shrink = ratio* bound_upperInfimumGeLowerSupremum.diameter.current.diameter.en / sumOfBorderRange;
			bound_upperInfimumGeLowerSupremum.lower.mark._ClampRatio_assumeRatioPositive( ratio2shrink);

			bound_upperInfimumGeLowerSupremum.upper.mark._ClampRatio_assumeRatioPositive( ratio2shrink);
			

		}

		public static void _Disengage_assumeSpanned(
			Bound1 bound
			,
			int v
		)
		{
			_Disengage_assumeSpanned( bound, new quotient_.Positive1(v) ) ;
		}

		public  static void _Disengage_assumeSpanned(
			this closed_.Spanned spanned
			,
			int v
		)
		{
			_Disengage_assumeSpanned( spanned, new quotient_.Positive1(v) ) ;
		}
	}
}
