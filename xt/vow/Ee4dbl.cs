using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.vow
{
	public class Ee4dbl
		: nilnul.obj.vow.Ee_ofIn<Ext4dblI>

	{
		public Ee4dbl(in Ext4dblI val, in VowI_ofIn<Ext4dblI> vow) : base(val, vow)
		{
		}

		public Ee4dbl(in Ext4dblI val, VowI_ofIn<Ext4dblI> vow) : base(val, vow)
		{
		}

		public Ee4dbl(Ext4dblI val, in VowI_ofIn<Ext4dblI> vow) : base(val, vow)
		{
		}
		public Ee4dbl(Ext4dbl val, in VowI_ofIn<Ext4dblI> vow) : base(val, vow)
		{
		}


		public Ee4dbl(Ext4dblI val, VowI_ofIn<Ext4dblI> vow) : base(val, vow)
		{
		}

		public Ee4dbl( double x, in VowI_ofIn<Ext4dblI> vow):this(new Ext4dbl(x), in vow )
		{
			
		}
	}
}
