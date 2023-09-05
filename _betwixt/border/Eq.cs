using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.border
{
	public class Eq1
		:nilnul.obj.border.Eq<R, nilnul.num.real.comp.Re,Border>
	{

		static public Eq1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq1>.Instance;
			}
		}
	}
}