using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border.upper_
{
	public class ClosedDbl : nilnul.num.real.border.AsUpperDbl
	{
		public ClosedDbl(double  val) : base(new BorderDbl(true,val) )
		{
		}
		public ClosedDbl():this(0)
		{

		}

		static public ClosedDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ClosedDbl>.Instance;
			}
		}

	}
}
