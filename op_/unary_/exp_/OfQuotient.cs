using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI;
using Q1 = nilnul.num.Quotient1;
using R1 = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_.exp_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _OfQuotientX
	{
		
		static public R1 RetRealI( Q1 q) {
			if (q<0)
			{
				return nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(
					new _exp.ret_.ofQuotient_.OfPositive(-q)
				);
			}
			if (q==0)
			{
				return nilnul.num.real_.Quotient.CreateOne();
			}
			if (q==1)
			{
				return  nilnul.num.real_.Euler.Singleton;

			}

			return new _exp.ret_.ofQuotient_.OfPositive(q);

		}
		static public Real RetReal(Q1 q) {
			return new Real(RetRealI(q));
			}

	






	}
}
