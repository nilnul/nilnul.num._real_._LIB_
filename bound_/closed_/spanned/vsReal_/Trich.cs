using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_.spanned.vsReal_
{
	namespace _trich
	{
		public enum Rel {
			LtLower
				,
			LtUpper
			,
			GtLower
		}
	}
	/// <summary>
	/// inside, 
	/// </summary>
	static public class _TrichX
	{
		static public _trich.Rel Trich(
			nilnul.num.real.bound_.closed_.Spanned spanned
			,
			nilnul.num.RealI real
		) {

			//nilnul.num.real.bound_.spanned_._DisengagedX._Disengage_assumeSpanned(spanned,1);
			nilnul.num.real.bound_.spanned_.disengaged.InnerOvColsX._assumeSpanned(spanned,1);


			var d = spanned.diameter;

			real.Clamp(d.current.lower.mark/2);


			if (real.current.upper.mark < spanned.lower.mark.current.lower)
			{
				return _trich.Rel.LtLower;
			}

			if (real.current.upper.mark < spanned.upper.mark.current.lower)
			{
				return _trich.Rel.LtUpper;
				

			}


			return _trich.Rel.GtLower;






			





		}
	}
}
