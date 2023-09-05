using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border.upper_
{
	public class OpenDbl : nilnul.num.real.border.AsUpperDbl
	{
		public OpenDbl(double  val) : base(new BorderDbl(false,val) )
		{
		}
		public OpenDbl():this(0)
		{

		}

		static public OpenDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OpenDbl>.Instance;
			}
		}

	}
}
