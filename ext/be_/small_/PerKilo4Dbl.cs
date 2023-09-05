using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be_.small_0
{

	public class PerKilo4Dbl
		: be_.Small4dbl

	{
		

		public PerKilo4Dbl():base(1d/1024 )
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
