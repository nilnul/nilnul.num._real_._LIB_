using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.dbl.border
{
	static public class _CoX
	{
		static public bool Contains(this border.Co duo,  R x)
		{
			return nilnul.num.dbl.border.comp_.lower.Re.Singleton.le(duo.lower, x)

				&&
				nilnul.num.dbl.border.comp_.upper.Re.Singleton.ge(duo.upper, x);

		}

		static public R Diameter(this border.Co duo)
		{
			return
				
				duo.upper.mark
				-
				duo.lower.mark
			;

		}

		static public R Center(this border.Co duo)
		{
			return
				
						(duo.lower.mark
						+
						duo.upper.mark)/2
					
				;

		}

	}
}
