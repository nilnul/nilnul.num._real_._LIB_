using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;

namespace nilnul.num.real.expr_.call_
{
	public class Unary
		: 
		nilnul._call_.op_.ArgA<nilnul.num.real.op_.UnaryI, nilnul.num.real.ExprI2>
		,
		nilnul.num.real.ExprI2
	{
		public Unary(nilnul.num.real.op_.UnaryI op, nilnul.num.real.ExprI2 arg) : base(op, arg)
		{
		}

		public Set2 vars
		{
			get
			{
				return arg.vars;

				throw new NotImplementedException();
			}
		}

		

		public ExprI2 substitute(VarI1 var, ExprI2 expr)
		{
			return new Unary(op,arg.substitute(var,expr));
			//throw new NotImplementedException();
		}
	}
}
