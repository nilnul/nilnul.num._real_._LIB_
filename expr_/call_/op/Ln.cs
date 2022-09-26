using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr.op
{
	public class Ln
	{
		static public ExprI Call(VarI x) {
			return new Call(real.op.Ln1.Singleton, x);
		}
		static public ExprI Call(ExprI x) {
			return new Call(real.op.Ln1.Singleton, x);
		}


	}
}
