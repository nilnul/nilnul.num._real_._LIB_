using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI_blank;
using V = nilnul.num.real.VarI;



namespace nilnul.num.real
{
	[Obsolete()]
	public interface ExprI1: 
		nilnul.obj.ExprI3<nilnul.num.RealI2>
		,
		_expr_.ReduceI
		,
		_expr_.SubstituteI
		,
		_expr_.VarsI
	{


	}



}
