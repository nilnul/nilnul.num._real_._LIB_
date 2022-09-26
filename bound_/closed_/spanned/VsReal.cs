using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_.spanned
{
	namespace _vsReal
	{
		public enum Rel {
			LtLower
				,
			LtUpperIncidentLower
				,
			Inner
			,
			GtLowerIncidentUpper
			,
			GtUpper
		}
	}
	/// <summary>
	/// inside, 
	/// </summary>
	static public class _VsRealX
	{
		static public _vsReal.Rel Relative(
			nilnul.num.real.bound_.closed_.Spanned spanned
			,
			nilnul.num.RealI real
		) {

			nilnul.num.real.bound_.spanned_._DisengagedX._Disengage_assumeSpanned(spanned);

			nilnul.num.real.bound_.spanned_.disengaged.InnerOvColsX._InnerOvCols_assumeDisengaged(spanned
			,1);
			var d = spanned.diameter;
			real.Clamp(d.current.lower.mark/2);


			if (real.current.upper.mark < spanned.lower.mark.current.lower)
			{
				return _vsReal.Rel.LtLower;
			}

			if (real.current.upper.mark < spanned.upper.mark.current.lower)
			{
				if (real.current.lower.mark <= spanned.lower.mark.current.upper)
				{
					return _vsReal.Rel.LtUpperIncidentLower;

				}
				return _vsReal.Rel.Inner;

			}
			//real.upper >= spannedUpperColLeft

			if (real.current.lower.mark > spanned.upper.mark.current.upper)
			{
				return _vsReal.Rel.GtUpper;
			}
			// real.lower <= spanned.UpperColRight

			return _vsReal.Rel.GtLowerIncidentUpper;

			//if (real.current.lower.mark > spanned.lower.mark.current.upper)
			//{
			//}






			





		}
	}
}
