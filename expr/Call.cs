using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI_blank;
using Expr = nilnul.num.real.ExprI;
using V = nilnul.num.real.VarI;

using nilnul._expr;
using nilnul.num.real.var;

namespace nilnul.num.real.expr
{
	public class Call:nilnul._call.CallA<real.OpI, nilnul.num.real.ExprI>
		,ExprI
	{

		public Call(OpI op, nilnul.num.real.ExprI arg):base(op,arg)
		{


		}

		public Call(OpI op,VarI var

			
			):this(
				op
				, new VarAsExpr(var)	
			)
		{

		}

		public nilnul.num.real.var.Set vars
		{
			get
			{
				return arg.vars;

				throw new NotImplementedException();
			}
		}

		

		public ExprI reduce()
		{
			var argReduced = arg.reduce();
			if (argReduced.vars.Count==0)
			{
				return new no.Call(
						op.eval((argReduced as no.Call).eval())
				)
				;
			}
			else
			{
				return new Call(op, argReduced);
			}

			throw new NotImplementedException();
		}

		public ExprI substitute(VarI var, ExprI expr)
		{
			return new Call(op, arg.substitute(var, expr));

			throw new NotImplementedException();
		}
	}
}
