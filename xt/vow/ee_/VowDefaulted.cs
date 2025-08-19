using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.vow.ee_
{
	public class VowDefaulted<TVow>
		:
		Ee4dbl
		where TVow : nilnul.obj.VowI_ofIn<Ext4dblI>, new()
	{
		public VowDefaulted(in Ext4dblI val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}

		

		public VowDefaulted(Ext4dblI val) : this(in val)
		{
		}

		public VowDefaulted(Ext4dbl val) : this((Ext4dblI) val)
		{
		}

	

		public VowDefaulted( double x) : this(new Ext4dbl(x))
		{
		}
	}
}
