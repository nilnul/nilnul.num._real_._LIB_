using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positive.ln_
{

	static public class _ByReverseExpX
	{
		static public RealI RetRealI_ofQuotientNotOne(PositiveI input)
		{
			return new _byReverseExp.Ret(input);
		}

		static public RealI RetRealI_ofQuotientNotOne(Positive input)
		{
			return new _byReverseExp.Ret(input);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"> maybe we can try ${input}= a^b; then we get a * ln(b) ? </param>
		/// <returns></returns>
		static public RealI RetRealI_unsureQuotient(Positive input)
		{
			return new _byReverseExp.Ret(input);
		}
		static public RealI RetRealI(nilnul.num.real_.Quotient v)
		{
			if (v == 1)
			{
				return new nilnul.num.real_.Quotient(0);
			}
			return RetRealI_ofQuotientNotOne(new Positive(v));
		}
		static public RealI RetRealI(BigInteger n)
		{
			return RetRealI(new num.real_.Quotient(n));
		}

		static public RealI RetRealI_unsureQuotient(Real v)
		{
			return RetRealI_unsureQuotient(new Positive(v));
		}

		static public RealI RetRealI_unsureQuotient(RealI par)
		{
			return RetRealI_unsureQuotient(new Positive(par));
		}

		static public RealI RetRealI(RealI par)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(par))
			{
				return RetRealI(new nilnul.num.real_.Quotient(par.current.lower.mark));
			};
			return RetRealI_unsureQuotient(par);
		}

		static public Real RetReal(RealI par)
		{
			return new Real(RetRealI(par));
		}
	}
}