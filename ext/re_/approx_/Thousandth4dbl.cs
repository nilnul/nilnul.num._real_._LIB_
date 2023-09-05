using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.ext.re_.approx_
{
	/// <summary>
	/// </summary>
	public class Thousandth4dbl 
		:
		re_.Approximate4dbl
	{

		public Thousandth4dbl() : base(0.001)
		{
		}

		static public Thousandth4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Thousandth4dbl>.Instance;
			}
		}



	}
}
