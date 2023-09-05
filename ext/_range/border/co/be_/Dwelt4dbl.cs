using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.be_
{
	public class Dwelt4dbl
		:co.Be4dbl_ofTupA
	{

		public override bool be(in (Border4dblI, Border4dblI) val)
		{
			return Single4dbl.Singleton.be(in val) && Spanned4dbl.Singleton.be(in val);
		}


		static public Dwelt4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Dwelt4dbl>.Instance;
			}
		}


	}
}
