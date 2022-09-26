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
	public class RadicGtOne
		:
		R
	{
		private nilnul.num.real_.GtOne _radicand;
		public nilnul.num.real_.GtOne radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}

		private R _index;
		public R index
		{
			get { return _index; }
			set { _index = value; }
		}



		public RadicGtOne(
			real_.GtOne radicand
			,
			R degree
		)

		{
			this._radicand = radicand;
			this._index = degree;

			var lowerRooted = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(
				radicand
				,
				_index.current.lower.mark
			);
			var upperRooted = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(
				radicand
				,
				_index.current.upper.mark
			);


			_bound = new q.bound_.Closed(
				lowerRooted.current.lower.mark,
				upperRooted.current.upper.mark);
		}

		public RadicGtOne(R radic, R index) : this(new real_.GtOne(radic), index)
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
			var diameter_oneThird = diameter / new quotient_.Positive1(3);
			while (
				current.diameterGt(diameter)
			)
			{
				_radicand.ClampHalf(
				);

				_index.squeeze(diameter_oneThird);

				var lowerPowed = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(radicand, _index.current.lower.mark);

				var upperPowed = real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(radicand
					,
					_index.current.upper.mark);

				lowerPowed.squeeze(diameter_oneThird);
				upperPowed.squeeze(diameter_oneThird);

				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					_bound
					,
					new q.bound_.Closed(
						lowerPowed.current.lower.mark,
						upperPowed.current.upper.mark
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
