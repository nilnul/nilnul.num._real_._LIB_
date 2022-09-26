using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.dbl.be_
{

	public class Nonneg
		:BeI
	{
		

		public bool be(double obj)
		{
			return obj >= 0;

		}




		static public Nonneg Singleton
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Nonneg>.Instance;
			}
		}






	}
}