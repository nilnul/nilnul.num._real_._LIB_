using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// in expr such as <see cref="nilnul.num.real.expr_.algebraic.Frac"/>, to determine whether the two frac is equal, we need to consider whether one's denominator is zero. But the denominator is composed of vars, and we cannot be guranteed that it's zero or not.
	/// We need to add or push a new posit to our axioms/posit set. and continue with the assumptions:
	///		1) either it's nil
	///		2) or it's not nil.
	///
	/// Also ,for expr involving cos(t),sin(t), we may at some stage to cancel some like : cos^2(t)+sin^2(t). The cancellation shall be based on some preset tautology/therorem/constraint.
	///
	/// The above two go beyond <see cref="num.real.IExpr"/> and is processed here at <see cref="IProof"/>
	/// </summary>
	class IProof
	{
	}
}
