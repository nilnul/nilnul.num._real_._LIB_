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
	public interface ExprI: nilnul.ExprI1<R>
		,nilnul._expr.VarsI<var.Set>
		,
		nilnul._expr.ReduceI<ExprI>
		,
		nilnul._expr.SubstituteI<V,ExprI>
	{


	}



}
