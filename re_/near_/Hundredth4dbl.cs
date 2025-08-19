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
	public class Hundredth4dbl 
		:
		re_.ApproximateDbl
	{

		public Hundredth4dbl() : base(1d/100)
		{
		}

		static public Hundredth4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Hundredth4dbl>.Unison;
			}
		}




	}
}
