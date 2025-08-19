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

namespace nilnul.num.real.of_.binary_._multi._ret0
{

	public class Demoting
		:
		calc_._binary.Args
	
	{

		public Demoting(R a, R b)
			: base(a, b)
		{
		}
		public Demoting(real_.Quotient_denomNonnil a, R b)
			: this(
				(RealI_onQuotient)(a), b
			)
		{
		}

		public Demoting(quotient_.DenomNonnil a, R b)
			: this(
				new real_.Quotient_denomNonnil(a), b
			)
		{
		}

		public Clamp current => arg.current.Multi(arg1.current);

		R0 _cinch_argQuotient(num.quotient_.denomNonnil_.Positive diameter)
		{

			while (current.Diameter() >= diameter)
			{
				var fDiameter = arg.current.Diameter();
				var sDiameter = arg1.current.Diameter();

				if (fDiameter == 0)
				{
					var scaled = op_._ScaleX.Op(arg.current.begin, arg1);
					scaled.cinch(diameter);
					return scaled;

				}
				else
				{
					if (sDiameter == 0)
					{
						var scaled = op_._ScaleX.Op(arg1.current.begin, arg);
						scaled.cinch(diameter);
						return scaled;

					}
					else
					{
						
						arg.CinchHalf(
							

						);
						arg1.CinchHalf(
							
						);

					}
				}

			}
			return this;
		}

		public override string ToString()
		{
			return $"{arg}{Multi.Sign}{arg1}";
		}
	}

}
