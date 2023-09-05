using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.re_.memberwise_.approx_
{
	public class PerKilo4Dbl
		: re_.memberwise_.Approx4Dbl
		
	{
		

		public PerKilo4Dbl():base(0.001 )
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
