using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{


	[Obsolete()]
	public class Func
		:
		nilnul._func.Func<num.real.var.TuplI, num.real.ExprI>
		,
		FuncI
	{
		public Func(
			num.real.var.TuplI input, num.real.ExprI expr
		):base(input, expr)
		{

		}



	}


}
