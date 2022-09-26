using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr.op
{
	public class Inverse
	{
		static public ExprI Call(ExprI x)
		{
			return new Call(real.op.Inverse2.Singleton, x);
		}

	}
}
