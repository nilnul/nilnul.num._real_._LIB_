using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class Set : nilnul.obj.Set<nilnul.num.RealI, nilnul.num.real.Eq>
	{
		public Set()
		{
		}

		public Set(params RealI[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<RealI> elements) : base(elements)
		{
		}
	}
}
