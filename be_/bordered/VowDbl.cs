using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bordered
{
	public class VowDbl : nilnul.num.real.be.VowDbl
	{
		public VowDbl(nilnul.num.real._border_.HasDblI be) : base(new nilnul.num.real.be_.BorderedDbl(be) )
		{

		}

		
	}
}
