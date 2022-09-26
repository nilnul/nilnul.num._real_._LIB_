using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bordered.vow.ee_
{
	public class BorderDefault<TBound> : Ee
	where TBound : _border_.HasI, new()
	{
		public BorderDefault(RealI val) : base(val, nilnul.obj_.Singleton<TBound>.Instance)
		{
		}
	}

	public class BoundDefaultDbl<TBound> : EeDbl
	where TBound : _border_.HasDblI, new()
	{
		public BoundDefaultDbl(double val) : base(val, nilnul.obj_.Singleton<TBound>.Instance)
		{
		}
	}

}
