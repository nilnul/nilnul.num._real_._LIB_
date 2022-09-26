using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bounded.vow.ee_
{
	public class BoundDefault<TBound> : Ee
	where TBound : Bound1, new()
	{
		public BoundDefault(RealI val) : base(val, nilnul.obj_.Singleton<TBound>.Instance)
		{
		}
	}

	public class BoundDefaultDbl<TBound> : EeDbl
	where TBound : BoundDbl, new()
	{
		public BoundDefaultDbl(double val) : base(val, nilnul.obj_.Singleton<TBound>.Instance)
		{
		}
	}

}
