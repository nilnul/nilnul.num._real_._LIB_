using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.alesce_.add
{
	public class Cumulator4float:
		nilnul.obj.op_.binary.cumulator_.opDefault_.ElDefault<float, Add>
	{
		public Cumulator4float() 
		{
		}


		static public Cumulator4float Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator4float>.Instance;
			}
		}


	}
}
