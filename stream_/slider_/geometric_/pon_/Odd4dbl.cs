using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.real.stream_.slider_.geometric_.pon_
{
	public class Odd4dbl : Geometric4dbl
	{
		public Odd4dbl(R head) : base(head, nilnul.num.real.op_.unary_.Square.Lazy.op(head))
		{
		}

	}
}
