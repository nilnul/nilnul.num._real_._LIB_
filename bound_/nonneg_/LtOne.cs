using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.nonneg_
{
	public class LtOne : nilnul.num.real.bound_.NonnegDbl
	{
		public LtOne( ) : base( new border.upper_.OpenDbl(1))
		{
		}

		static public LtOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LtOne>.Instance;
			}
		}

	}
}
