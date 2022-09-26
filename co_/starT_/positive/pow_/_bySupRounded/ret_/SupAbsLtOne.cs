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

namespace nilnul.num.real.co_.starT_.positive.pow_._bySupRounded.ret_
{
	//[Obsolete("the sup is not quotient, so the boundEnd of radic is quotient, and quotient^sup is still not computable with this (m/n is quotient, we don't know how to compute (m/n)^sup, where sup is irrational);")]
	public class SupAbsLtOne
		:
		R
	{
		private nilnul.num.real_.PositiveI _radicand;
		public nilnul.num.real_.PositiveI radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}

		private R _degree;
		public R degree
		{
			get { return _degree; }
			set { _degree = value; }
		}


		public SupAbsLtOne(
			real_.PositiveI radicand,
			R degree

		)
		{
			this._radicand = radicand;
			this._degree = degree;



			var lowerPowed = real_.positive.op_.unary_._PowX.RetRealI(
				radicand, _degree.current.lower.mark);
			var upperPowed = real_.positive.op_.unary_._PowX.RetRealI(radicand, _degree.current.upper.mark);

			_bound = q.bound_.Closed.Create_orderIfNecessary(

						nilnul.num.quotient.op_.binary_._MinX.Min(
							lowerPowed.current.lower.mark, upperPowed.current.lower.mark)
						,
						nilnul.num.quotient.op_.binary_._MaxX.Max(lowerPowed.current.upper.mark, upperPowed.current.upper.mark)

			);
		}

		public SupAbsLtOne(R radic, R index) : this(new real_.Positive(radic), index)
		{
		}

		public SupAbsLtOne(Q1 radic, R index):this(new real_.Positive(radic),index  )
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

				_degree.squeeze( diameter_oneThird);/// this will not work out

				var lowerPowed = real_.positive.op_.unary_._PowX.RetRealI(
					radicand, _degree.current.lower.mark
				);

				var upperPowed = real_.positive.op_.unary_._PowX.RetRealI(
					radicand, _degree.current.upper.mark);

				lowerPowed.squeeze(diameter_oneThird);
				upperPowed.squeeze(diameter_oneThird);


				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					_bound,
					q.bound_.Closed.Create_orderIfNecessary(

						nilnul.num.quotient.op_.binary_._MinX.Min(lowerPowed.current.lower.mark, upperPowed.current.lower.mark)
						,
						nilnul.num.quotient.op_.binary_._MaxX.Max(lowerPowed.current.upper.mark, upperPowed.current.upper.mark)
						
					)
				);

#if DEBUG
				var diameter2watch = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_bound.diameter, 10u);
				var radicand2watch = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_radicand.current.mid, 10u);

				var dec = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_bound.mid, 10u);
#endif

			}

		}
	}
}
