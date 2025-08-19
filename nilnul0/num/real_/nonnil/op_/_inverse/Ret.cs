using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.RealI_onQuotient;//.rational.Rational_InheritFraction2;
using Q0 = nilnul.num.quotient_.DenomNonnil;//.rational.Rational_InheritFraction2;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

using nilnul.num.quotient.range.be_;
using N0I = nilnul.num.real_.NonnilI_onQuotient;
using N0 = nilnul.num.real_.Nonnil_onQuotient;

using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonnil.vow;
using nilnul.obj.stream_._slider._skid_;
using nilnul.num.real;
using nilnul.num.quotient.co;

namespace nilnul.num.real_.nonnil.op_._inverse
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
			nilnul.num.real_.nonnil.calc_._unary.Arg
			,
			real_.NonnilI_onQuotient
			,
			//real.be.NotZero.Asserted
			//,
			RealI_onQuotient
	{

		public Ret(real_.NonnilI_onQuotient a)
			: base(a)
		{
		}

		public Ret(real_.Nonnil_onQuotient a)
			: base(a)
		{
		}


		public Ret(R a)
		: this(new real_.Nonnil_onQuotient(a))
		{
		}


		public Ret(BigInteger a)
				: this(new real_.Nonnil_onQuotient(a))
		{
		}

		public Ret(Ee_onQuotient arg1):this( new real_.Nonnil_onQuotient(arg1))
		{
		}

		public (Q0 begin, Q0 end) current =>nilnul.num.quotient.clasp_.invertible.op_._InverseX._ToClasp_0invertibleClasp(
			arg.real.eeByRef.current
		); 

		public 	Ee_onQuotient real =>this.arg.real; 


		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			while (current.Diameter()>(diameter))
			{
				this.arg.CinchHalf(
				);
			}
		}
	}
}
