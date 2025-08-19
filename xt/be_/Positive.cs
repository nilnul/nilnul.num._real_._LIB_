using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be_
{
	public class Positive : ext.Be4dblI
	{
		public bool be(in Ext4dblI val)
		{
			return val.errable > 0;
			//throw new NotImplementedException();
		}


		static public Positive Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positive>.Instance;
			}
		}

	}
}
