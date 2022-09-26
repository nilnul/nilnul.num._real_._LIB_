using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bounded
{
	public class VowDbl : nilnul.num.real.be.VowDbl
	{
		public VowDbl(BoundDbl be) : base(new nilnul.num.real.be_.BoundedDbl(be) )
		{

		}

		
	}
}
