using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be_
{
	public class Nonpositive :
		ext.be.anto_.BeDefaulted<Positive>
		,
		ext.Be4dblI
	{
		//public bool be(in Ext4dblI val)
		//{
		//	return val.concil <= 0;
		//	//throw new NotImplementedException();
		//}


		static public Nonpositive Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nonpositive>.Instance;
			}
		}

	}
}
