using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.comp
{
	[Obsolete()]
	public class Re:nilnul.obj.comp.Re<nilnul.num.RealI, nilnul.num.real.Comparer>
	{

		static public Re Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Re>.Instance;
			}
		}

	}
}
