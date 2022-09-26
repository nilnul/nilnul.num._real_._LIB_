using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.comp
{
	public class Re:nilnul.obj.comp.Re<double, nilnul.num.dbl.Comp>
	{


		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}


	}
}
