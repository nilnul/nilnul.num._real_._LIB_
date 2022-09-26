using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.alesce_.add
{
	public class Cumulator4dbl:
		nilnul.obj.op_.binary.cumulator_.opDefault_.ElDefault<double, Add>
	{
		public Cumulator4dbl() : base()
		{
		}


		static public Cumulator4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator4dbl>.Instance;
			}
		}


	}
}
