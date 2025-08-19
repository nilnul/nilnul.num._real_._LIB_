using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr.re.call_
{
	/// <summary>
	/// express the equation of two exprs
	/// </summary>
	public class Eq
		: nilnul.num.real.expr.re.Call
	{
		public Eq(Tuple<ExprI, ExprI> tuple) : base(nilnul.num.real.re_.Eq.Singleton, tuple)
		{
		}

		public Eq((ExprI, ExprI) valTuple) : base(nilnul.num.real.re_.Eq.Singleton,valTuple)
		{
		}

		public Eq(ExprI item1, ExprI item2) : base(nilnul.num.real.re_.Eq.Singleton,item1, item2)
		{
		}
		public Eq(nilnul.num.real.VarI item1, ExprI item2) : this(new nilnul.num.real.expr_.Var( item1 ), item2)
		{
		}

		public Eq( ExprI item1_1, nilnul.num.real.VarI item2) : this( item1_1, new nilnul.num.real.expr_.Var(item2))
		{
		}


	}
}
