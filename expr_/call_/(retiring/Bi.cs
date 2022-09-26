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
	[Obsolete()]

	public class Bi
	:
	nilnul.obj.call_.Duo<nilnul.num.real.duo.OpI, nilnul.num.real.ExprI1, nilnul.num.real.ExprI1>
		,
	nilnul.num.real.ExprI1

	{
		public Bi(
			nilnul.num.real.duo.OpI op,
				nilnul.num.real.ExprI1 x, nilnul.num.real.ExprI1 y
		)
			: base(op, x, y)
		{

		}

		



		public var.Set1 vars
		{
			get
			{
				var r = new nilnul.num.real.var.Set1();
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





		public num.real.ExprI1 substitute(num.real.VarI var, num.real.ExprI1 expr)
		{
			return new Bi(
				this.op,
				(arg ).substitute(var, expr),
				(arg1).substitute(var, expr)

		);
			//throw new NotImplementedException();
		}

		public ExprI1 reduce()
		{


			var argReduced = (arg ).reduce();
			var arg1Reduced = (arg1).reduce();

			if (argReduced is call_.Ni && arg1Reduced is call_.Ni)
			{
				return new call_.Ni(
					op.eval(

						(argReduced as call_.Ni).arg
						,
						(arg1Reduced as call_.Ni).arg
					)

				);
			}
			else
			{
				return new Bi(
					op
					,
					argReduced, arg1Reduced
				);
			}

			throw new NotImplementedException();
		}

	

	}

}
