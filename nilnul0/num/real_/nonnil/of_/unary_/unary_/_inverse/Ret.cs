using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.RealI3;//.rational.Rational_InheritFraction2;
using Q0 = nilnul.num.Quotient1;//.rational.Rational_InheritFraction2;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num._real.approach;
using nilnul.num.quotient.range.be_;
using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num._real._cauchy._approach_;
using nilnul.num._real._cauchy.approach.be_.limit_.nonnil.vow;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num._real._cauchy.approach_.nonnil.op_.unary_._inverse
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		consider:
	///			1) 1/(1-x)=1+x+x^2+...
	///			2) 1/(1-x)=(1+x)(1+x^2)(1+x^4).
	/// </remarks>
	public class Ret
				:
			nilnul.num._real._cauchy.approach_.nonnil._call.Arg
			,

			approach_.NonnilI
			,
			//real.be.NotZero.Asserted
			//,
			ApproachI
	{

		public Ret(approach_.NonnilI a)
			: base(a)
		{
		}


		public Ret(A a)

		: this(new approach_.Nonnil(a))

		{

		}


		public Ret(BigInteger a)
				: this(new approach_.Nonnil(a))
		{
		}
		public Range1 range =>nilnul.num.quotient.range_.invertible.op_.unary_._InverseX._Range_assumeInvertible(
			arg.nonnil.en.range
		);


		public En nonnil => new nilnul.num._real._cauchy.approach_.Nonnil(this);

		public void squeeze(quotient_.Positive1 diameter)
		{
			

			while (range.notSpanLessThan(diameter))
			{
				arg.Clamp1K(
				);

			}

			//return;

			//	throw new NotImplementedException();
		}

	}
}
