using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.comp
{
	[Obsolete()]
	public class Re1:nilnul.obj.comp.Re<nilnul.num.RealI, nilnul.num.real.Comparer1>
	{
		static public Re1 Singleton
		{
			get
			{
				return nilnul.Singleton1<Re1>.Instance;
			}
		}
	}
}
