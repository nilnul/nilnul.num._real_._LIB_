using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.insignific_
{

	public class PerKilo4Dbl
		: be_.Insignificant4dbl
		,
		nilnul.num.real.BeDblI
	{

		public PerKilo4Dbl():base( num.real_.nonneg.be_.small_.PerKilo4Dbl.Singleton)
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
