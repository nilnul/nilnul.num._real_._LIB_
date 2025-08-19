using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using Q0 = nilnul.num.Quotient1;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using R = nilnul.num.RealI_onQuotient;
using nilnul.num.quotient_;
using nilnul.num.quotient.co;
using nilnul.num.quotient.clamp.of_;

namespace nilnul.num.real.of_.binary_._multi
{

	public  class ReplaceBoxedExpr
		:
		R
	{
		RealI_onQuotient _alternateive;

		public ReplaceBoxedExpr(R a, R b)
		{
			_alternateive = new _ret.Ret(a,b);
		}

		public ReplaceBoxedExpr(real_.Quotient_denomNonnil a, R b)
			: this(
				(RealI_onQuotient)(a), b
			)
		{
		}

		public ReplaceBoxedExpr(quotient_.DenomNonnil a, R b)
			: this(
				new real_.Quotient_denomNonnil(a), b
			)
		{
		}

		public Clamp current => _alternateive.current;
		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			_alternateive.c

			bool _f = true, _s = true;

			while (current.Diameter() >= diameter)
			{
				var fDiameter = arg.current.Diameter();
				var sDiameter = arg1.current.Diameter();

				if (fDiameter == 0)
				{
					arg1.CinchHalf();
				}
				else
				{
					if (sDiameter == 0)
					{
						arg.CinchHalf();
					}
					else
					{
						var sum = fDiameter + sDiameter;

						var first = fDiameter / sum;
						var second = sDiameter / sum;

						var totalCount = 1024;
						var min = 16;

						var firstTimes = totalCount * first;
						if (firstTimes < min)
						{
							firstTimes = min;
						}

						var secondTimes = totalCount * second;
						if (secondTimes < min)
						{
							secondTimes = min;
						}

						arg.cinch(
							new quotient_.denomNonnil_.Positive(
								fDiameter / firstTimes

							)

						);
						arg1.cinch(
							new quotient_.denomNonnil_.Positive(
								sDiameter / secondTimes

							)
						);

					}
				}



			}
		}


		public override string ToString()
		{
			return $"{_alternateive}";
		}
	}

}
