using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co_.dwelt.be_.has_
{
	static public class _ExtremX
	{

		static public  bool _HasExtrem_0dwelt(this in (Border4dblI, Border4dblI) obj)
		{
			return border.Eq4dbl.Singleton.eq( obj.Item1, Ext4dbl.NegInf   )
				||
				border.Eq4dbl.Singleton.eq( obj.Item2, Ext4dbl.PosInf   )
			;
		}
	}
}
