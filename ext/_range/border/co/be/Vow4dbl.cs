using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow_ofIn<
			(Border4dblI, Border4dblI)
		>
	{
		public Vow4dbl(in BeI_ofIn<(Border4dblI, Border4dblI)> val) : base(val)
		{
		}

		public Vow4dbl(BeI_ofIn<(Border4dblI, Border4dblI)> x) : base(x)
		{
		}
	}
}
