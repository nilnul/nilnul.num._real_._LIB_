using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.be_
{
	public class Single4dbl
		:
		real.ext.border.co.Be4dblA
		,
		real.ext.border.co.Be4dblI
		,
		real.ext.border.co.Be4dbl_ofTupI

	{
		public override bool be(in real.ext.border.Co4dbl obj)
		{
			return
				nilnul.obj.border.co.be_.single_.EqDefault<Ext4dblI,Border4dblI, real.ext.Eq4dbl>.Singleton.be(
					obj
			);
		}

		public bool be(in (Border4dblI, Border4dblI) obj)
		{
			return
				nilnul.obj.border.co.be_.single_.EqDefault<Ext4dblI,Border4dblI, real.ext.Eq4dbl>.Singleton.be(
					obj
			);

		}


		static public Single4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Single4dbl>.Instance;
			}
		}

	}
}
