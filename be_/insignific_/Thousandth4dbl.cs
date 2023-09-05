using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.insignific_
{

	public class Thousandth4dbl
		: be_.Insignificant4dbl
		,
		nilnul.num.real.BeDblI
	{
		

		public Thousandth4dbl():base(num.real_.nonneg.be_.small_.Thousandth4dbl.Singleton )
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
