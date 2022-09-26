using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._expr.expr_.call_.poly_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _BernsteinX
	{
		static public Expression _Gen(
			int all,
			int part
			
		)
		{

			Expression<
				Func<nilnul.num.RealI, nilnul.num.RealI  >
			> l =	(
				nilnul.num.RealI x
			)
			=>
			nilnul.num.co_.ge._CombinateX._assumeNumGe(all, part)
			*
			(
				nilnul.num.real.op_.unary_._PolyX.RealI(x, part).ToReal()
			)
			*
			nilnul.num.real.op_.unary_._PolyX.RealI(
				(1 - x.ToReal()), all - part
			);

			var e = l.Body;
			return e;


		}
		static public Expression _Gen(
			int all,
			int part
			,
			ParameterExpression x
		) {

			var oldE = _Gen(all, part);

			var replaced = nilnul.obj._expr.untyped.var.SubstituteX.Substitute(oldE,

				nilnul.obj._expr.untyped._VarsX._Vars_assumeNonlambda(oldE).First()
				,
				x
			);
			return replaced;

			 
				


		}

	}

	/*
	 * 
https://en.wikipedia.org/wiki/Bernstein_polynomial

	 **********************/

}
