using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.be_.small_
{

	public class PerKilo4Dbl
		: be_.Small4dbl
		
	{
		public const double UPPER = 1d / 1024;

		public PerKilo4Dbl():base( UPPER)
		{
				
		}


		static public  PerKilo4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<PerKilo4Dbl>.Instance;
			}
		}


	}
}
