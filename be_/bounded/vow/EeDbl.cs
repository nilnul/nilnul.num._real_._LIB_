using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bounded.vow
{
	public class EeDbl : nilnul.num.real.vow.EeDbl
	{
		public EeDbl(double val, BoundDbl vow) : base(val, new bounded.VowDbl(vow))
		{
		}
	}
}
