using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.interval_.clopen_.closeLeft_
{
	public class RightInf
	{
		private nilnul.num.Real _left;

		public nilnul.num.Real left
		{
			get { return _left; }
			set { _left = value; }
		}

		public RightInf(nilnul.num.Real left)
		{
			_left = left;
		}
	}
}
