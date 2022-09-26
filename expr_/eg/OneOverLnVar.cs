using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr.eg
{
	public class OneOverLnVar
		
	{
		static public ExprI Create(VarI x) {
			return nilnul.num.real.expr.op.Inverse.Call(
				nilnul.num.real.expr.op.Ln.Call(x)	
			);
		}
	}
}
