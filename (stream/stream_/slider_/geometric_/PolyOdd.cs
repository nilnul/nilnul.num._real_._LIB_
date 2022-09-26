using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_.geometric_
{
	public class PolyOdd : Geometric
	{
		public PolyOdd(num.RealI head) : base(head, nilnul.num.real.op_.unary_.Square.Lazy.op(head))
		{
		}

	}
}
