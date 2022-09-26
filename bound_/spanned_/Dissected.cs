using nilnul.be.vow;
using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.spanned_
{
	static public class _DissectedX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bound_upperInfimumGeLowerSupremum"></param>
		/// <param name="ratio"></param>
		static public void _Dissect_assumeSpanned(
			this nilnul.num.real.Bound1 bound_upperInfimumGeLowerSupremum
		)
		{
			var outerBound = bound_upperInfimumGeLowerSupremum.Outer();

			nilnul.num.real_._positive._Clamp_ofAssumePositiveX.MakeLowerNonneg_assumePositive(
				bound_upperInfimumGeLowerSupremum.upper.mark
				-
				bound_upperInfimumGeLowerSupremum.lower.mark.ToReal()
			);
		}

		public static void _Dissect_assumeSpanned(
			this closed_.Spanned spanned
			
		)
		{
			_Dissect_assumeSpanned((Bound1)spanned);
		}
	}

	/// <summary>
	/// the two col/border's quotient range is away or tangent, but not sected/intersected
	/// </summary>
	static public class DissectedX
	{
		static public nilnul.num.quotient.bound_.Closed _Inner_assumeDissected(nilnul.num.real.Bound1 _dissected)
		{

			return new quotient.bound_.Closed(
				_dissected.lower.mark.current.upper.mark,
				_dissected.upper.mark.current.lower.mark
			);

		}

		static public nilnul.num.quotient_.Nonneg _InnerDiameter_assumeDissected(nilnul.num.real.Bound1 _dissected)
		{

			return new quotient_.Nonneg(
				_dissected.upper.mark.current.lower.mark
				-
				_dissected.lower.mark.current.upper.mark

			);

		}



	}
}
