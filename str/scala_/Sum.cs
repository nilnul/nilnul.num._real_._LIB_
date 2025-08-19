using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.num.real.str.to_.scalar_
{
	public class Sum
	   :
	   ScalarI
	{
		public R to(IEnumerable<R> src)
		{
			return nilnul.num.real.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(src);
		}


		static public Sum Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Sum>.Instance;
			}
		}

	}
}
