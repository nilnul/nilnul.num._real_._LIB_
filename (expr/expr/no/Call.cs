using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;
using R = nilnul.num.RealI;

namespace nilnul.num.real.expr.no
{
	public class Call:
		nilnul.expr.no._call.Call<R>
		,
		nilnul.ExprI
	{

		public Call(R r):base(r)
		{

		}

		public nilnul.num.real.var.Set vars
		{
			get
			{
				return new nilnul.num.real.var.Set();
				throw new NotImplementedException();
			}
		}

		public nilnul.ExprI reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		public nilnul.ExprI substitute(nilnul.VarI var, nilnul.ExprI expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}
}
