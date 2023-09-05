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
	/// alias:
	///		thousandth;
	public class Milli4dbl 
		:
		re_.ApproximateDbl
	{

		public Milli4dbl() : base(0.001)
		{
		}

		static public Milli4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Milli4dbl>.Instance;
			}
		}



	}
}
