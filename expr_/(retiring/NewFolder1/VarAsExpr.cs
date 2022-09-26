using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;
using R = nilnul.num.Real;
using V = nilnul.num.real.VarI1;


namespace nilnul.num.real.expr_
{
	public class Var
		:
		nilnul.expr_.Var<nilnul.num.RealI2,nilnul.num.real.VarI1>
		,

		nilnul.num.real.ExprI2
	{

		public Var(V x):base(x)
		{

		}

		public Set2 vars
		{
			get
			{
				return new Set2( this.var);
				//throw new NotImplementedException();
			}
		}

		

		public ExprI2 substitute(V var, ExprI2 expr)
		{
			if (var == this)
			{
				return expr;
			}
			else
			{
				return this;
			}
			//throw new NotImplementedException();
		}
	}
}
