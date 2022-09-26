using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using V = nilnul.num.real.VarI;


namespace nilnul.num.real.expr
{
	[Obsolete()]
	public class VarAsExpr
		:nilnul.expr.VarAsExpr1<V,var.Set>
		, nilnul.ExprI
	{

		public VarAsExpr(V x):base(x)
		{

		}

		public nilnul.ExprI reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		public nilnul.ExprI substitute(V var, nilnul.ExprI expr)
		{
			if (var == this)
			{
				return expr;
			}
			else
			{
				return this;
			}
			throw new NotImplementedException();
		}
	}
}
