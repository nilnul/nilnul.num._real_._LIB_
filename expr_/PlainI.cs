using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using V = nilnul.num.real.VarI;


namespace nilnul.num.real.expr_
{
	/// <summary>
	/// var 
	/// or 
	/// call_.nary/unary/binary
	/// </summary>
	public interface PlainI
		:
		_plain_.VarsI
		,
		_plain_.SubstituteI
		//,
		//nilnul.num.real.IExpr
		,
		nilnul.num.real.ExprI
	{
	}
}
