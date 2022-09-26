using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using V = nilnul.num.real.VarI;

namespace nilnul.num.real
{

	public class Expr :
	nilnul.obj.Box1<ExprI>
	,
	ExprI
	{
		public Expr(ExprI val) : base(val)
		{
		}

		public Expr(V var):this(
			new nilnul.num.real.expr_.Var(var)
		)
		{
		}

		public nilnul.num.real.var.Set vars => boxed.vars;

		public ExprI substitute(VarI var, ExprI expr)
		{
			return boxed.substitute(var, expr);
			//throw new NotImplementedException();
		}

		static public  ExprI operator -(
			Expr x, ExprI y
		)
		{
			return 
				new expr_.call_.Binary(
					nilnul.num.real.op_.binary_.Minus.Singleton,x,y
			);
		}

		static public  ExprI operator -(
			Expr x, nilnul.NumI1 y
		)
		{
			return
				x - new expr_.call_.Nary(
					y
				);
		}


		static public  ExprI operator *(
			Expr x, Expr y
		)
		{
			return 
				new expr_.call_.Binary(
					nilnul.num.real.op_.binary_.Multi.Singleton,x,y
			);
		}


	}
	public static class ExprX
	{
		static public ExprI Minus(this ExprI x, ExprI y) {
			return new expr_.call_.Binary(
				nilnul.num.real.op_.binary_.Minus.Singleton
				,
				x,
				y
			);
		}

		static public nilnul.num.real.Expr ToExpr(this nilnul.num.real.VarI var) {
			return new nilnul.num.real.Expr(var);
		}
	}

}