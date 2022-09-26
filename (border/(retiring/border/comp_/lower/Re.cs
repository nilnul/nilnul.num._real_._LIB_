using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.border.comp_.lower
{
	public class Re:nilnul.num.dbl.border.comp.Re<Lower>
	{

		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}

		internal bool le(Border left, double x)
		{
			return le(left, Border.CreateClose(x));
		}
	}
}
