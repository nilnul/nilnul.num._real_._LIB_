using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.call_.aggregated_
{
	public class Prod :
		nilnul.obj.Box1<
		nilnul.num.real.ExprsI
	>
		,
		nilnul.num.real.ExprI
	{
		public Prod(ExprsI val) : base(val)
		{
		}

		public Prod():this(
			new Exprs()
		)
		{

		}

		public Prod(IEnumerable<ExprI> enumerable)
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
			return new Prod(
				this.boxed.Select(
					e=>e.substitute(var,expr)
				)
			);
			//throw new NotImplementedException();
		}
	}
}
