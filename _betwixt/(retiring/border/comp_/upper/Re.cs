using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.border.comp_.upper
{
	public class Re:nilnul.num.dbl.border.comp.Re<Upper>
	{

		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}

		public bool ge(Border upper, double x)
		{
			return this.ge(upper, Border.CreateClose(x));
		}
	}
}
