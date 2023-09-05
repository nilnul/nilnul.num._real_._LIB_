using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.be_.dwelt_
{
	public class NoExtrem
		: ext.border.co.Be4dbl_ofTupA
	{

		public override bool be(in (Border4dblI, Border4dblI) val)
		{
			return Dwelt4dbl.Singleton.be(in val) && co_.dwelt.be_.has_.extrem._AntoX._NoExtrem_0dwelt(in val);
		}


		static public NoExtrem Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NoExtrem>.Instance;
			}
		}

	}
}
