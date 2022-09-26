using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.call_.aggregated_
{
	public class Sum :
		nilnul.obj.Box1<
		nilnul.num.real.ExprsI
	>
		,
		nilnul.num.real.ExprI
	{
		public Sum(ExprsI val) : base(val)
		{
		}

		public Sum():this(
			new Exprs()
		)
		{

		}

		public Sum(IEnumerable<ExprI> enumerable)
			:this(
				 new Exprs(enumerable)
			)
		{
		}

		public var.Set vars
		{
			get
			{
				var r = new var.Set();

				this.boxed.Each(
					e =>
					r.UnionWith(e.vars)
				);

				return r;

			}
		}

		public ExprI substitute(real.VarI var, ExprI expr)
		{
			return new Sum(
				this.boxed.Select(
					e=>e.substitute(var,expr)
				)
			);
			//throw new NotImplementedException();
		}
	}
}
