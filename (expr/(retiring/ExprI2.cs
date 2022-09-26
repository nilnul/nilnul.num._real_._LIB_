using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;

namespace nilnul.num.real
{
	public interface ExprI2:
		nilnul.num.real._expr_.BlankI
		,
		nilnul.ExprI1<nilnul.num.Real>
		,
		_expr_.SubstituteI1
		,
		_expr_.VarsI1
	{
	}




}
