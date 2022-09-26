using System;

namespace nilnul.num.real
{
	[Obsolete()]
	public interface ExprI: 
		
		_expr_.SubstituteI
		,
		_expr_.VarsI
		,
		num.real._expr_.BlankI
		,
		IExpr
	{

	}

}