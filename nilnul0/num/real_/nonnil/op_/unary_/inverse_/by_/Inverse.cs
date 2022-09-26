using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num._real.approach;
using nilnul.num.quotient.range.be_;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach_.nonnil.op_.unary_.inverse_.by_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		consider:
	///			1) 1/(1-x)=1+x+x^2+...
	///			2) 1/(1-x)=(1+x)(1+x^2)(1+x^4).
	/// </remarks>
	static public class _OneMinusProperInverseExpansionX
	{


		static public A Approach_assumeProper(A x)
		{
			return new _oneMinusProperInverseExpansion.Ret(x);
		}

		static public A Approach_assumePositive(A x)
		{
			if (x.range.upper.mark < 1)
			{
				return Approach_assumeProper(x);
			}

			return approach.op_.unary_._ScaleX.Div(
				Approach_assumeProper(

					approach.op_.unary_._ScaleX.Div(x, 2 * x.range.upper.mark)
				)
				,
				2 * x.range.upper.mark

			);
		}



		static public A Approach(approach_.NonnilI x)
		{
			if (x.range.upper.mark < 0)
			{
				return Approach_assumePositive(approach.op_.unary_.Negate.Singleton.op(x));
			}
			return Approach_assumePositive((x));
		}




	}
}
