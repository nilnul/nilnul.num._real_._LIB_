using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be_
{
	public class GtOne : ext.Be4dblI
	{
		public bool be(in Ext4dblI val)
		{
			return  val.errable >1;
		}


		static public GtOne Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<GtOne>.Instance;
			}
		}

	}
}
