using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.call_.poly_
{
	public class Chromatic
		:
		call_.aggregated_.Prod

	{
		public Chromatic(
			nilnul.num.real.VarI var
			,
			nilnul.NumI1 count
		)
			:base(
				 new nilnul.nums_.Before(count).Select( i=> var.ToExpr()-(i) )
			)
		{
		}

		
	}
}
