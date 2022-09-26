using nilnul.be.vow;
using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.spanned_.disengaged
{
	static public class InnerOvColsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bound_upperInfimumGeLowerSupremum"></param>
		/// <param name="innerOvCols">
		/// how much the inner takes among the sum of cols
		/// </param>
		static public void _InnerOvCols_assumeDisengaged(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.Positive1 innerOvCols
		) {

			var sumOfBorderRange = (
				bound_upperInfimumGeLowerSupremum.lower.mark.current.diameter
				+
				bound_upperInfimumGeLowerSupremum.upper.mark.current.diameter
			);

			if (sumOfBorderRange ==0)
			{
				return;
			}

			//var diameter = ;

			var ratio2shrink = spanned_.DissectedX._InnerDiameter_assumeDissected(bound_upperInfimumGeLowerSupremum)
				/
				(  sumOfBorderRange.en *innerOvCols)
			;

			bound_upperInfimumGeLowerSupremum.lower.mark._ClampRatio_assumeRatioPositive( ratio2shrink);

			bound_upperInfimumGeLowerSupremum.upper.mark._ClampRatio_assumeRatioPositive( ratio2shrink);

		}
		static public void _assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.Positive1 innerOvCols
		)
		{
			real.bound_.spanned_._DisengagedX._Disengage_assumeSpanned(bound_upperInfimumGeLowerSupremum);
			_InnerOvCols_assumeDisengaged(bound_upperInfimumGeLowerSupremum, innerOvCols);
		}

		public static void _InnerOvCols_assumeDisengaged(
			Bound1 bound
			,
			nilnul.num.Quotient1 v
		)
		{
			_InnerOvCols_assumeDisengaged( bound, new quotient_.Positive1(v) ) ;
		}


		public static void _InnerOvCols_assumeDisengaged(
			Bound1 bound
			,
			int v
		)
		{
			_InnerOvCols_assumeDisengaged( bound, new quotient_.Positive1(v) ) ;
		}



		public  static void _InnerOvCols_assumeDisengaged(
			this closed_.Spanned spanned
			,
			int v
		)
		{
			_InnerOvCols_assumeDisengaged( spanned, new quotient_.Positive1(v) ) ;
		}
		public static void _assumeSpanned(
			Bound1 bound
			,
			nilnul.num.Quotient1 v
		)
		{
			_assumeSpanned( bound, new quotient_.Positive1(v) ) ;
		}

		public static void _assumeSpanned(
			Bound1 bound
			,
			int v
		)
		{
			_assumeSpanned( bound, new quotient_.Positive1(v) ) ;
		}

		public  static void _assumeSpanned(
			this closed_.Spanned spanned
			,
			int v
		)
		{
			_assumeSpanned( spanned, new quotient_.Positive1(v) ) ;
		}


	}
}
