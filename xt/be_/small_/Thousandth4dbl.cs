using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be_.small_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		milli
	public class Thousandth4dbl
		: be_.Small4dbl

	{
		

		public Thousandth4dbl():base(0.001 )
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
