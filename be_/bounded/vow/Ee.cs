using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bounded.vow
{
	public class Ee : nilnul.num.real.vow.Ee
	{
		public Ee(RealI val, Bound1 vow) : base(val, new bounded.Vow(vow))
		{
		}
	}
}
