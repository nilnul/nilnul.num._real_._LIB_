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
	[Obsolete("too slow, use " + nameof(_Cos_byClampArgX), true)]

	static public class _CosX
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
			
			return new _cos.Of(arg);
		}


		public static R RealI(RealI arg)
		{
			return _SinX.RetRealI(
(nilnul.num.real_.Tau.Singleton.ToReal() / 4) - arg
			);

			var divided = arg / (nilnul.num.real_.Tau.Singleton.ToReal() / 4);

			var rounded = nilnul.num.real.to_.Round.Eval(divided);   //

			var argReal = new Real(arg);

			//divided =

			var expressed =  argReal +(nilnul.num.real_.Tau.Singleton.ToReal() / 4) - ( rounded) * (nilnul.num.real_.Tau.Singleton.ToReal() / 4);  //+(round-1) * tau/4	     //pi/2


			//expressed is (-t/4, t/4) in Sin(x)			///todo: this will not work in Cos
			///we need to make it into (0, t/2)


			//var rounMod2 = rounded % 2;

			var roundMod4 = (int)(nilnul.num.integer.op_.binary_._RemainderX.Remainder(rounded-1, 4));


			//cos(x + k*t/4)= cos(x)cos(k*t/4) - sin(x)sin(k*t/4);
			switch (roundMod4)
			{
				case 0:
					return RealI_ofRemainder(
						expressed
					);
				case 1:
					return _SinX.RetRealI_ofRemainder(expressed).Negate();
				case 2:
					return RealI_ofRemainder(expressed).Negate();

				default:
					return _SinX.RetRealI_ofRemainder(expressed);
					break;
			}


		}

	}

}
