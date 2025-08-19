using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.be_.small_
{

	public class Thousandth4dbl
		: be_.Small4dbl
		
	{
		public const double UPPER = 0.001;

		public Thousandth4dbl():base( UPPER)
		{
				
		}


		static public  Thousandth4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Thousandth4dbl>.Instance;
			}
		}


	}
}
