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
	static public class _SubsetX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public bool Subset(nilnul.num.real.ext.BorderI x, nilnul.num.real.ext.BorderI y)
		{
			return _SupersetX.Re(y,x);

		}
	}
}
