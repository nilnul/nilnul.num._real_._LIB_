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

namespace nilnul.num.real.op_.unary_.poly_.powPlural_._byOpBaseBorder
{
	public class Ret
		:
		R
	{
		private nilnul.num.RealI _radicand;
		public nilnul.num.RealI radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}

		private nilnul.Num1 _degree;
		public nilnul.Num1 degree
		{
			get { return _degree; }
			set { _degree = value; }
		}



		public Ret(
			RealI radicand,
			nilnul.Num1 degree

		)

		{
			this._radicand = radicand;
			this._degree = degree;

			///consider if the radicand bound contains nil, then there is a low point in the mapped bound which fall out of the bound of borderOped

			var lowerRooted = pow_._OfIndexQuotientX.RetRealI_assumeRadicPositive(radicand.en.bound.lower.mark, _degree.bound.lower.mark);
			var upperRooted = pow_._OfIndexQuotientX.RetRealI_assumeRadicPositive(radicand.en.bound.upper.mark, _degree.bound.upper.mark);



			var lowerBorder = new nilnul.num.quotient.Border2(
				radicand.en.bound.lower.openFalseCloseTrue && lowerRooted.bound.lower.openFalseCloseTrue
				, lowerRooted.bound.lower.mark
			);


			var upperBorder = new nilnul.num.quotient.Border2(
				radicand.en.bound.upper.openFalseCloseTrue
				&& upperRooted.bound.upper.openFalseCloseTrue
				,
				upperRooted.bound.upper.mark
			);




			_bound = new q.Bound(lowerBorder, upperBorder);





		}

		public Ret(R radic, R index) : this(new be_.gtOne.vow.En(radic), index)
		{
		}

		private q.Bound _bound;
		public q.Bound bound
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

				bound.notSpanLessThan(diameter)


				)
			{
				_radicand.en.ClampHalf(
				);


				_degree.ClampHalf();

				var lowerPowed = pow_._OfIndexQuotientX.RetRealI_assumeRadicPositive(radicand.en.bound.lower.mark, _degree.bound.lower.mark);
				var upperPowed = pow_._OfIndexQuotientX.RetRealI_assumeRadicPositive(radicand.en.bound.upper.mark, _degree.bound.upper.mark);

				lowerPowed.squeeze(diameter_oneThird);
				upperPowed.squeeze(diameter_oneThird);

				/*
				while (lowerPowed.bound.upper.mark > upperPowed.bound.lower.mark)
				{
					lowerPowed.Clamp1K();
					upperPowed.Clamp1K();
				}

				var apartDistance = upperPowed.bound.lower.mark - lowerPowed.bound.upper.mark;
				bool lower2converge = true, upper2converge = true;
				do
				{
					if (lowerPowed.bound.diameter > apartDistance)
					{
						lowerPowed.Clamp1K();
					}
					else
					{
						lower2converge = false;
					}
					if (upperPowed.bound.diameter > apartDistance)
					{
						upperPowed.Clamp1K();

					}
					else
					{
						upper2converge = false;
					}
					/// converge smaller than gap
					apartDistance = upperPowed.bound.lower.mark - lowerPowed.bound.upper.mark;

				} while (lower2converge||upper2converge);
	

				*/

				var lowerBorder = new nilnul.num.quotient.Border2(
					radicand.en.bound.lower.openFalseCloseTrue && lowerPowed.bound.lower.openFalseCloseTrue
					,
					lowerPowed.bound.lower.mark
				);


				var upperBorder = new nilnul.num.quotient.Border2(
					radicand.en.bound.upper.openFalseCloseTrue
					&& upperPowed.bound.upper.openFalseCloseTrue
					,
					upperPowed.bound.upper.mark
				);




				_bound = nilnul.num.quotient.bound.co_.joint._IntersectX.Intersect(_bound, new q.Bound(lowerBorder, upperBorder));

#if DEBUG
				var diameter2watch = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_bound.diameter, 10u);
				var radicand2watch = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_radicand.en.bound.midPoint, 10u);

				var dec = nilnul.num.quotient_.radix_.Dec1.FroQuotient(_bound.midPoint, 10u);
#endif

			}

		}
	}
}
