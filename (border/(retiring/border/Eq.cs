using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.dbl.border
{
	public class Eq
		:nilnul.obj.border.Eq<R, nilnul.num.dbl.Eq,dbl.Border>
	{


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}