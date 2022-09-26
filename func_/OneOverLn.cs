using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func.eg
{
	public class OneOverLn
	{
		static public FuncI Create(VarI x) {
			return new Func(new var.tupl.Seed(x), num.real.expr.eg.OneOverLnVar.Create(x) );

		}
	}
}
