using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.obj.expr.stati._stati;
using nilnul.bit.expr.stati;
using nilnul._expr;
using nilnul.bit._expr;
using nilnul.bit.var;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI1;

namespace nilnul.num.real.expr_.call_
{

	public class Binary
	:
	nilnul._call_.op_.arg_.arg1_.ArgsSameType<nilnul.num.real.op_.BinaryI, nilnul.num.real.ExprI2>
		,
	nilnul.num.real.ExprI2

	{
		public Binary(
			nilnul.num.real.op_.BinaryI op,
				nilnul.num.real.ExprI2 x, nilnul.num.real.ExprI2 y
		)
			: base(op, x, y)
		{

		}

		



		public var.Set2 vars
		{
			get
			{
				var r = new nilnul.num.real.var.Set2();
				r.UnionWith(
						(arg).vars

					);
				r.UnionWith(
						(arg1).vars

					);
				return r;


				//throw new NotImplementedException();
			}
		}





		public num.real.ExprI2 substitute(num.real.VarI1 var, num.real.ExprI2 expr)
		{
			return new Binary(
				this.op,
				(arg ).substitute(var, expr),
				(arg1).substitute(var, expr)

		);
			//throw new NotImplementedException();
		}

		
	

	}

}
