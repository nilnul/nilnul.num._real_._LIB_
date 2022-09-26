using nilnul.be.vow;
using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.spanned_.disengaged
{
	static public class InnerOvDiameterX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bound_upperInfimumGeLowerSupremum"></param>
		/// <param name="innerOvDiameter">
		/// how much the inner takes among the diamter
		/// </param>
		static public void _assumeDisengaged(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.Portion innerOvDiameter
		) {

			InnerOvColsX._InnerOvCols_assumeDisengaged(
				bound_upperInfimumGeLowerSupremum
				,
				innerOvDiameter/ ( 1-innerOvDiameter.ee.ToClass() )
				/*
				  let i := inner
				  let c := cols inside border
				let a := innerOvDiameter intended, the given par
					b:= col widthS sum
				then we need
					 i / (c+i) >= a
				which is equiv to:
					i/a - i >=c
				this is satifiable by:
					i/a -i >= b
				which is equiv to:
					i / ( i /a - i )  <= i/b
					a/(1-a) <=i/b
				By calling Make_InnerOvCols_Ge with a/(1-a), we make i/b >= a/(1-a), eventually making c<= i/a-i, and then i/(c+i) >= a 

				 
				 */

			);

		}
		public static void _assumeDisengaged(
			Bound1 bound
			,
			nilnul.num.QuotientI1 v
		)
		{
			_assumeDisengaged( bound, new quotient_.Portion(v) ) ;
		}

		static public void _assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.Portion innerOvDiameter
		)
		{

			spanned_._DisengagedX._Disengage_assumeSpanned(bound_upperInfimumGeLowerSupremum);
			_assumeDisengaged(bound_upperInfimumGeLowerSupremum, innerOvDiameter);

		}


		public static void _assumeSpanned(
			Bound1 bound
			,
			nilnul.num.QuotientI1 v
		)
		{
			_assumeSpanned( bound, new quotient_.Portion(v) ) ;
		}


		static public quotient.bound_.Closed Inner_assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
			,
			nilnul.num.quotient_.Portion innerOvDiameter
		)
		{

			spanned_._DisengagedX._Disengage_assumeSpanned(bound_upperInfimumGeLowerSupremum);
			_assumeDisengaged(bound_upperInfimumGeLowerSupremum, innerOvDiameter);
			return real.bound_.spanned_.DissectedX._Inner_assumeDissected(bound_upperInfimumGeLowerSupremum);

		}

		public static quotient.bound_.Closed Inner_assumeSpanned(
			Bound1 bound
			,
			nilnul.num.QuotientI1 v
		)
		{
			return Inner_assumeSpanned( bound, new quotient_.Portion(v) ) ;
		}



		
	}
}
