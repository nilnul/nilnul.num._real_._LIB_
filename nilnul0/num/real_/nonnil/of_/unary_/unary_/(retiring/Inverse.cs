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

namespace nilnul.num._real.approach_.nonzero.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		consider:
	///			1) 1/(1-x)=1+x+x^2+...
	///			2) 1/(1-x)=(1+x)(1+x^2)(1+x^4).
	/// </remarks>
	/// 
	[Obsolete()]
	public  class Inverse
	{


		static public ApproachI1 Eval(ApproachI1 x) {
			return new _inverse.Ret(x);
		}


	}
}
