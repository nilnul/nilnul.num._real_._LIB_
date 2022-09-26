using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;
using R = nilnul.num.RealI;
using V = nilnul.num.real.VarI;


namespace nilnul.num.real.expr_
{
	[Obsolete()]
	public class Var
		:
		nilnul.obj.expr_.VarAsExpr<R,V>
		,
		nilnul.num.real.ExprI
		,
		PlainI


	{

		public Var(V x):base(x)
		{

		}

		public var.Set vars => new var.Set(this.var);

		public ExprI substitute(V var, ExprI expr)
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

		public PlainI substitute(V var, PlainI expr)
		{

			if (var == this)
			{
				return expr;
			}
			else
			{
				return this;
			}
		}

		static public implicit operator Var(nilnul.num.real.Var1 var) {
			return new Var(var);
		}

		//public override string ToString()
		//{
		//	return base.ToString();	
		//}
	}
}
