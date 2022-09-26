using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using R = nilnul.num.RealI;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.real.op_.unary_
{
	[Obsolete("too slow, use "+nameof(_Sin_byClampArgX), true)]
	static public class _SinX
	{
		internal static R RetRealI(Q0 mark)
		{
			if (mark == 0)
			{
				return new nilnul.num.real_.Quotient(0);

			}
			return new _sin.ret_.OfQuotientNonnil(mark);
			//throw new NotImplementedException();
		}

		/// <summary>
		/// around (-tau/4, tau/4); may be outside of this interval, but will not exceed [-tau/2, tau/2]
		/// </summary>
		/// <param name="arg"></param>
		/// <returns></returns>
		public static R RetRealI_ofRemainder(R arg)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(arg))
			{
				return RetRealI(arg.current.lower.mark);

			}

			
			return new _sin.Ret_ofMaybeIrration(arg);
		}
		/// <summary>
		/// para may be large
		/// </summary>
		/// <param name="arg"></param>
		/// <returns></returns>
		public static R RetRealI(RealI arg)
		{
			var divided = arg / (nilnul.num.real_.Tau.Singleton.ToReal() / 4);

			var rounded = nilnul.num.real.to_.Round.Eval(divided);




			var expressed =arg - rounded * (nilnul.num.real_.Tau.Singleton.ToReal() / 4);  //+round* tau/4	     //pi/2

			//var rounMod2 =  rounded % 2;
			var roundMod4 =(int) ( nilnul.num.integer.op_.binary_._RemainderX.Remainder( rounded ,4 ) );

			//sin(x + k*t/4)= sin(x)cos(k*t/4) + cos(x)sin(k*t/4);
			switch (roundMod4)
			{
				case 0:
					return RetRealI_ofRemainder(
						expressed
					);
				case 1:
					///(-t/4, t/4)
					return _CosX.RealI_ofRemainder(expressed);
				case 2:
					return RetRealI_ofRemainder(expressed).Negate();
				
				default:
					return _CosX.RealI_ofRemainder(expressed).Negate();
					break;
			}

			
		}


	}

}
