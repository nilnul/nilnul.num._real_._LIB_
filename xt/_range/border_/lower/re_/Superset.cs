using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border_.lower.re_
{
	/// <summary>
	/// one set includes the other
	/// </summary>
	static public class _SupersetX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public bool Re(nilnul.num.real.ext.BorderI x, nilnul.num.real.ext.BorderI y)
		{
			if (x.openFalseCloseTrue)
			{

				return nilnul.num.real.ext.re_._LeX.Le(x.mark, y.mark);


			}
			if (y.openFalseCloseTrue)
			{
				return nilnul.num.real.ext.re_._LtX.Lt(x.mark, y.mark);

			}
			return nilnul.num.real.ext.re_._LeX.Le(x.mark, y.mark);

		}
	}
}
