using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.interval_.clopen_.closeLeft_.rightInf_
{
	public class LeftZero : RightInf
	{
		public LeftZero() : base(0)
		{
		}


		static public LeftZero Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LeftZero>.Instance;
			}
		}

	}
}
