using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.re_
{
	public class Le
		: nonneg.Re4dblI
	{
		public bool re(NonnegOfDoubleI a, NonnegOfDoubleI b)
		{
			return a.realee.ee < b.realee.ee;
		}


		static public Le Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Le>.Instance;
			}
		}

	}
}
