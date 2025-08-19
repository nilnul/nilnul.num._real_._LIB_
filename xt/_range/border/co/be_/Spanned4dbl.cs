using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.be_
{
	public class Spanned4dbl
		:
		real.ext.border.co.Be4dbl_ofTupA
		,
		real.ext.border.co.Be4dblI
		,
		real.ext.border.co.Be4dbl_ofTupI

	{
		public override bool be(in (Border4dblI, Border4dblI) obj)
		{
			return
				nilnul.obj.border.co.be_.spanned_.CompDefault<Ext4dblI,Border4dblI, real.ext.Comparer4dbl>.Singleton.be(
					obj
			);

		}
		public  bool be(in real.ext.border.Co4dbl obj)
		{
			return base.be( ((Border4dblI,Border4dblI))obj )			;
		}


		static public Spanned4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Spanned4dbl>.Instance;
			}
		}

	}
}
