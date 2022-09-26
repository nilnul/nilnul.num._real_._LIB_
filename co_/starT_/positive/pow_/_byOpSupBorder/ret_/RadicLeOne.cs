using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.Num1;
using R = nilnul.num.RealI;
using Q1 = nilnul.num.Quotient1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;

namespace nilnul.num.real.co_.starT_.positive.pow_._byOpSupBorder.ret_
{
	public class RadicLeOne
		:
		R
	{
		private nilnul.num.real_.positive_.LeOne _radicand;
		public nilnul.num.real_.positive_.LeOne radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}

		private R _sup;
		public R sup
		{
			get { return _sup; }
			set { _sup = value; }
		}



		public RadicLeOne(
			real_.positive_.LeOne radicand,
			R sup

		)
		{
			this._radicand = radicand;
			this._sup = sup;

			var lowerRooted = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(
				radicand
				,
				_sup.current.lower.mark
			);

			var upperRooted = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(
				radicand
				,
				_sup.current.upper.mark
			);

			_bound = new q.bound_.Closed(
				upperRooted.current.lower.mark
				,
				lowerRooted.current.upper.mark
			);
		}

		public RadicLeOne(R radic, R index) : this(new real_.positive_.LeOne(radic), index)
		{
		}

		private q.bound_.Closed _bound;
		public q.bound_.Closed current
		{
			get
			{
				return _bound;
			}
		}


		public void squeeze(quotient_.Positive1 diameter)
		{
			var diameter_oneThird = diameter / (3u);
			while (
				current.diameterGt(diameter)
			)
			{
				_radicand.ClampHalf(
				);

				_sup.squeeze(
					diameter_oneThird
				);

				var lowerPowed = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(
					radicand
					,
					_sup.current.lower.mark
				);

				var upperPowed = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(
					radicand
					,
					_sup.current.upper.mark
				);

				lowerPowed.squeeze(diameter_oneThird);
				upperPowed.squeeze(diameter_oneThird);

				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					_bound
					,
					new q.bound_.Closed(
						upperPowed.current.lower.mark
						,
						lowerPowed.current.upper.mark
					)
				);

#if DEBUG
				var diameter2watch = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_bound.diameter1, 10u);
				var radicand2watch = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_radicand.en.current.midPoint, 10u);

				var dec = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_bound.midPoint, 10u);
#endif

			}

		}
	}
}
