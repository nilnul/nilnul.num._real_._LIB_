using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow_ofIn<
			Ext4dblI
		>
	{
		public Vow4dbl(in BeI_ofIn<Ext4dblI> val) : base(val)
		{
		}

		public Vow4dbl(BeI_ofIn<Ext4dblI> x) : base(x)
		{
		}
	}
}
