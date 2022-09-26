using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num;

namespace nilnul.num.real.op_.unary_.arctg_._ofAbsCircaOne.ret_
{
	/// <summary>
	/// 
	/// </summary>
	public class OfDiameterLe4Tenth :
		nilnul.obj.Box<nilnul.num.RealI>
		,
		nilnul.num.RealI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_around1_diameterLe4Tenth">
		/// in ( tg(tau/12) = 1/cubicRoot(3) ,  tg(tau/6) = cubicRoot(3) )
		/// </param>
		public OfDiameterLe4Tenth(nilnul.num.RealI _around1_diameterLe4Tenth) : base(_around1_diameterLe4Tenth)
		{
			//var cubicRoot3 = nilnul.num.real.op_.unary_.Sqrt.Singleton.op(3);

			var tauOver6 = nilnul.num.real_.Tau.Singleton.ToReal() / 6;

			var tauOver12 = tauOver6 / 2;

			//tauOver6.Clamp( nilnul.num.Quotient1.CreateHalf());

			tauOver6.Clamp(1);
			_current = new quotient.bound_.Closed(
				tauOver12.current.lower.mark
				,
				tauOver6.current.upper.mark
			);
		}

		private num.quotient.bound_.Closed _current;
		public num.quotient.bound_.Closed current => _current;

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			var _par2squeezeto = diameter * (1
				+ nilnul.num.quotient.op_.unary_._SquareX.Square(
					nilnul.num.quotient.op_.binary_._MinX.Min(
						nilnul.num.quotient.op_.unary_._AbsX.Op(
							boxed.current.lower
						)
						,
						nilnul.num.quotient.op_.unary_._AbsX.Op(
							boxed.current.upper
						)
					)
				)
			);
			var par2squeezeToOverFour = new Positive1(
				_par2squeezeto / 4
			);

			this.boxed.squeeze(
					par2squeezeToOverFour
			);

			var lowerOped = nilnul.num.real.convert_.arctg_._OfQuotientX._ofAbsLeOne(boxed.current.lower);
			var upperOped = nilnul.num.real_.TauX.Quarter - nilnul.num.real.convert_.arctg_._OfQuotientX._ofAbsLeOne(1 / boxed.current.upper.mark);

			lowerOped.squeeze(
				par2squeezeToOverFour
			);

			upperOped.Clamp(
				_par2squeezeto / 2
			);

			_current = new quotient.bound_.Closed(
				lowerOped.current.lower
				,
				upperOped.current.upper
			);



		}
	}
}

