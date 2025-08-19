using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_
{
	/// <summary>
	/// the expr is unconstrained, or in other words, the constraint is omega.
	/// Note, the <see cref="expr.IDefined"/> can still be not omega.
	/// for a <see cref="expr.IDefined"/> to be omega, <see cref="expr_.IUniversal"/>
	/// </summary>
	public interface IUnconstrained:IExpr
	{
	}
}
