using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using R = nilnul.num.RealI;//._cauchy.ApproachI;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.real.op_.unary_
{
	static public class _Cos_byClampArgX
	{
		internal static R RealI(Q0 mark)
		{
			if (mark == 0)
			{
				return new nilnul.num.real_.Quotient(1);

			}

			return new _cos.of_.QuotientNotNil(mark);
			//throw new NotImplementedException();
		}

		/// <summary>
		/// around (-tau/4, tau/4); may be outside of this interval, but will not exceed [-tau/2, tau/2]
		/// this is a concaved function, not montonic
		/// </summary>
		/// <param name="arg"></param>
		/// <returns></returns>
		public static R RealI_ofRemainder(R arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return RealI(arg.current.lower.mark);
			}
			
			return new _cos.Ret_ofAcute_byClampArg(arg);
		}


		public static R RealI(RealI arg)
		{
			return _Sin_byClampArgX.RetRealI(
(nilnul.num.real_.Tau.Singleton.ToReal() / 4) - arg
			);

			


		}

	}
	
}
