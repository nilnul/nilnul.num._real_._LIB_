using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_.spanned.vsReal_.trich_
{
	namespace _ge
	{
		public enum Rel {
			GeUpper
			,
			GeLower
				,
			LtUpper
		}
	}
	/// <summary>
	/// inside, 
	/// </summary>
	static public class _GeX
	{
		static public _ge.Rel Trich(
			nilnul.num.real.bound_.closed_.Spanned spanned
			,
			nilnul.num.RealI real
		) {

			nilnul.num.real.bound_.spanned_.disengaged.InnerOvColsX._assumeSpanned(spanned, 1);
			var d = spanned.diameter;
			real.Clamp(d.current.lower.mark/2);


			if (real.current.lower.mark >= spanned.upper.mark.current.upper)
			{
				return _ge.Rel.GeUpper;
			}

			if (real.current.lower.mark >= spanned.lower.mark.current.upper)
			{
				return  _ge.Rel.GeLower;
				

			}


			return _ge.Rel.LtUpper;






			





		}
	}
}
