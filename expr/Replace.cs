using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr
{
	/// <summary>
	/// replace one sub-expr with another expre
	/// <seealso cref="nilnul.num.real._expr_.SubstituteI"/>
	/// </summary>
	interface IReplace
	{
	}

	public interface RelaceI {
		nilnul.num.real.ExprI relace(
			nilnul.num.real.ExprI wholeExpr
			,
			ref nilnul.num.real.ExprI subExpr
			,
			nilnul.num.real.ExprI newSubExpr


		);
	}
}
