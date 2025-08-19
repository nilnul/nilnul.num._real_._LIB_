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
	public class Tenth4dbl 
		:
		re_.ApproximateDbl
	{

		public Tenth4dbl() : base(.1d)
		{
		}

		static public Tenth4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Tenth4dbl>.Unison;
			}
		}




	}
}
