using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.expr_
{

	public class Var1 : nilnul.obj.expr_.typed_.generi_.Var<R>
		,
		VarI
	{

		public Var1(ParameterExpression val) : base(val)
		{
		}

		public Var1(string s) : this( Expression.Parameter(typeof(num.RealI),s))
		{
		}
		public Var1():this(Expression.Parameter(typeof(num.RealI)))
		{
		}
	}
}
