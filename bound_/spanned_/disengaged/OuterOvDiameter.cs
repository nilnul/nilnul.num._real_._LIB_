using nilnul.be.vow;
using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.spanned_.disengaged
{
	static public class OuterOvDiameterX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bound_upperInfimumGeLowerSupremum"></param>
		/// <param name="outerOvDiameter">
		/// how much the inner takes among the diamter
		/// </param>
		static public void _assumeDisengaged(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.GtOne outerOvDiameter
		) {

			var sumOfBorderRange = bound_upperInfimumGeLowerSupremum.lower.mark.current.diameter
							+
							bound_upperInfimumGeLowerSupremum.upper.mark.current.diameter
			;

			if (sumOfBorderRange == 0)
			{
				return;
			}

			var ratio2shrink =(outerOvDiameter -1)
				*
				spanned_.DissectedX._InnerDiameter_assumeDissected(bound_upperInfimumGeLowerSupremum) 
				/
				(sumOfBorderRange.en )
			;

			bound_upperInfimumGeLowerSupremum.lower.mark._ClampRatio_assumeRatioPositive(ratio2shrink);

			bound_upperInfimumGeLowerSupremum.upper.mark._ClampRatio_assumeRatioPositive(ratio2shrink);

		}
		public static void _assumeDisengaged(
			Bound1 bound
			,
			nilnul.num.QuotientI1 v
		)
		{
			_assumeDisengaged( bound, new quotient_.GtOne(v) ) ;
		}

		static public void _assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.GtOne outerOvDiameter
		)
		{

			spanned_._DisengagedX._Disengage_assumeSpanned(bound_upperInfimumGeLowerSupremum);
			_assumeDisengaged(bound_upperInfimumGeLowerSupremum, outerOvDiameter);

		}


		public static void _assumeSpanned(
			Bound1 bound
			,
			nilnul.num.QuotientI1 v
		)
		{
			_assumeSpanned( bound, new quotient_.GtOne(v) ) ;
		}


		static public quotient.bound_.Closed Outer_assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.GtOne outerOvDiameter
		)
		{

			spanned_._DisengagedX._Disengage_assumeSpanned(bound_upperInfimumGeLowerSupremum);
			_assumeDisengaged(bound_upperInfimumGeLowerSupremum, outerOvDiameter);
			return real.BoundX.Outer(bound_upperInfimumGeLowerSupremum);

		}

		public static quotient.bound_.Closed Outer_assumeSpanned(
			Bound1 bound
			,
			nilnul.num.QuotientI1 v
		)
		{
			return Outer_assumeSpanned( bound, new quotient_.GtOne(v) ) ;
		}

		public static quotient.bound_.Closed Outer_assumeSpanned(Bound1 bound, int v)
		{
			return Outer_assumeSpanned(bound, new nilnul.num.Quotient1(v));
			;
		}
	}
}
