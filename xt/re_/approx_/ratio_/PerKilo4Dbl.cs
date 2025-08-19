using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.ext.re_.approx_.ratio_
{
	/// <summary>
	/// </summary>
	public class PerKilo4Dbl 
		:
		re_.approx_.Ratio
	{

		public PerKilo4Dbl() : base(0.001)
		{
		}

		static public PerKilo4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<PerKilo4Dbl>.Instance;
			}
		}



	}
}
