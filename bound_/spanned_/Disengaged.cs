using nilnul.be.vow;
using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.spanned_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _DisengagedX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bound_upperInfimumGeLowerSupremum"></param>
		/// <param name="ratio"></param>
		static public void _Disengage_assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
		)
		{
			//var outerBound = bound_upperInfimumGeLowerSupremum.Outer();



			nilnul.num.real_._positive._Clamp_ofAssumePositiveX.MakeLowerNonneg_assumePositive(
				bound_upperInfimumGeLowerSupremum.upper.mark
				-
				bound_upperInfimumGeLowerSupremum.lower.mark.ToReal()
			);
		}

		public static void _Disengage_assumeSpanned(
			this closed_.Spanned spanned

		)
		{
			_Disengage_assumeSpanned((Bound1)spanned);
		}
	}


}
