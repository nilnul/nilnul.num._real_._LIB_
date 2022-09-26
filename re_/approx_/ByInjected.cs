using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.re_.approx_
{
	/// <summary>
	/// </summary>
	public class ByInjected 
		:
		nilnul.num.real.ReDblI
	{
		public ByInjected()
		{
		}

		public bool re(double a, double b)
		{
			return real.be_.AboutNil4Dbl.Injected.be(a - b);
		}

		static public ByInjected Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ByInjected>.Instance;
			}
		}
	}
}