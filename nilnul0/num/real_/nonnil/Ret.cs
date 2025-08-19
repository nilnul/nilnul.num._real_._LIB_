using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.RealI;//.rational.Rational_InheritFraction2;
using Q0 = nilnul.num.Quotient1;//.rational.Rational_InheritFraction2;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

using nilnul.num.quotient.range.be_;
using A = nilnul.num.real_.NonnilI;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonnil.vow;

namespace nilnul.num.real_.nonnil
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		consider:
	///			1) 1/(1-x)=1+x+x^2+...
	///			2) 1/(1-x)=(1+x)(1+x^2)(1+x^4).
	/// </remarks>
	public class Inversed
				:
			nilnul.obj.calc_._unary.Arg<num.real.be_.nonnil.vow.Ee_onQuotient>
			,
			real_.NonnilI
			,
			//real.be.NotZero.Asserted
			//,
			RealI
	{

		public Inversed(real_.NonnilI a)
			: base(a)
		{
		}


		public Inversed(R a)
		: this(new real_.Nonnil(a))
		{
		}


		public Inversed(BigInteger a)
				: this(new real_.Nonnil(a))
		{
		}
		public num.quotient.bound_.Closed current =>nilnul.num.quotient.bound_.closed_.invertible.op_.unary_._InverseX._Closed_assumeInvertible(
			arg.real.en.current
		);

		public En real =>this.arg.real;


		public void squeeze(num.quotient_.Positive1 diameter)
		{
			while (current.diameterGt(diameter))
			{
				arg.Clamp1K(
				);
			}
		}
	}
}
