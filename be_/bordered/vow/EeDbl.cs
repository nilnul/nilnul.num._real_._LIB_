using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bordered.vow
{
	public class EeDbl : nilnul.num.real.vow.EeDbl
	{
		public EeDbl(double val, real._border_.HasDblI vow) : base(val, new bordered.VowDbl(vow))
		{
		}
	}
}
