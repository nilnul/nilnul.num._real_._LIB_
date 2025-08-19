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

namespace nilnul.num.real.bi_._mul
{

	public class Ret
		:
		calc_._binary.Args
		,
		R
	{

		public Ret(R a, R b)
			: base(a, b)
		{
		}
		public Ret(real_.Quotient_denomNonnil a, R b)
			: this(
				(RealI_onQuotient)(a), b
			)
		{
		}

		public Ret(quotient_.DenomNonnil a, R b)
			: this(
				new real_.Quotient_denomNonnil(a), b
			)
		{
		}

		public Clamp current => arg.current.Multi(arg1.current);

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{

			while (current.Diameter() >= diameter)
			{
				var diameter1st = arg.current.Diameter();

				if (diameter1st == 0)
				{
					arg1._CinchHalf_0spanned();
					_cinch_0quotient(
						diameter
					);
					return;
				}

				var sDiameter = arg1.current.Diameter();
				if (sDiameter == 0)
				{
					arg._CinchHalf_0spanned();
					_cinch_1quotient(
						diameter
					);
					return;

				}

				arg.CinchHalf(

				);
				arg1.CinchHalf(
				);
			}
		}
		void _cinch_0quotient(num.quotient_.denomNonnil_.Positive diameter)
		{

			while (current.Diameter() >= diameter)
			{

				arg1._CinchHalf_0spanned();


			}
		}
		void _cinch_1quotient(num.quotient_.denomNonnil_.Positive diameter)
		{

			while (current.Diameter() >= diameter)
			{

				arg._CinchHalf_0spanned();


			}
		}

		public override string ToString()
		{
			return $"{arg}{bi_._MultiplyX.SIGN}{arg1}";
		}
	}

}
