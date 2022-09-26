using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;

namespace nilnul.num.real.expr_.call_
{
	[Obsolete()]

	public class Uni
		: nilnul.obj.expr_.call_.Uni<nilnul.num.real.OpI2, nilnul.num.real.ExprI1>
		,
		nilnul.num.real.ExprI1
	{
		public Uni(nilnul.num.real.OpI2 op, nilnul.num.real.ExprI1 arg) : base(op, arg)
		{
		}

		public Set1 vars
		{
			get
			{
				return arg.vars;

				throw new NotImplementedException();
			}
		}

		public ExprI1 reduce()
		{
			var argReduced = arg.reduce();
			if (argReduced is call_.Ni)
			{
				return new call_.Ni(
					op.eval( (arg as call_.Ni).arg)	
				);
			}
			return new Uni(op,argReduced);
			//throw new NotImplementedException();
		}

		public ExprI1 substitute(VarI var, ExprI1 expr)
		{
			return new Uni(op,arg.substitute(var,expr));
			//throw new NotImplementedException();
		}
	}
}
