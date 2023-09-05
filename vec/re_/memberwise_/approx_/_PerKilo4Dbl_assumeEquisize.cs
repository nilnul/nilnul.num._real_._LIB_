using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.re_.memberwise_.approx_
{
	 public class _PerKilo4Dbl_assumeEquisize
		:
		_Approx_assumeEquisize

	{
		public _PerKilo4Dbl_assumeEquisize() : base(0.001)
		{
		}


		static public _PerKilo4Dbl_assumeEquisize Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<_PerKilo4Dbl_assumeEquisize>.Instance;
			}
		}


	}
}
