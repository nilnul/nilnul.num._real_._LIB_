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
	public class Myriadth4dbl 
		:
		re_.ApproximateDbl
	{

		public Myriadth4dbl() : base(.001d)
		{
		}

		static public Myriadth4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Myriadth4dbl>.Unison;
			}
		}




	}
}
