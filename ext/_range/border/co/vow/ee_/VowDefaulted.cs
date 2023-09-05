using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.vow.ee_
{
	public class VowDefaulted<TVow>
		:
		Ee4dbl
		where TVow : nilnul.obj.VowI_ofIn<(Border4dblI, Border4dblI)>, new()
	{
		public VowDefaulted(in (Border4dblI, Border4dblI) val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}

		

		public VowDefaulted((Border4dblI, Border4dblI) val) : this(in val)
		{
		}

	
	}
}
