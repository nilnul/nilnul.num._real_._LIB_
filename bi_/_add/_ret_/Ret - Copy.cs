using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using R = nilnul.num.RealI_onQuotient;//.real.RealI_posConverge2NonEmpty;
using A = nilnul.num.RealI_onQuotient;//.real.RealI_posConverge2NonEmpty;

using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.border.duo.be_;
using Q0 = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient_;
using nilnul.num.quotient;
using nilnul.num.quotient.co;

namespace nilnul.num.real.of_.binary_._add
{

	public class Ret
		:
		nilnul.num.real.calc_._binary.Args 
		,
		R0
	{





		public Ret(R a, A b)
			: base(a, b)
		{


		}
		public Ret(nilnul.num.real_.Quotient_denomNonnil a, A b)
			: this(
				(R)(a), b
			)
		{


		}

		public Ret(Q0 a, A b)
			: this(
				new real_.Quotient_denomNonnil(a), b
			)
		{


		}
		public Clamp current =>
			num.quotient.clamp.of_._BinaryX.Add(arg.current,  arg1.current);


		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{


			//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

			bool _f = true, _s = true;

			while (current.Diameter() > (diameter))
			{
				if (_f)
				{
					var fDiameter = arg.current.Diameter();
					if (fDiameter == 0)
					{
						_f = false;
					}
					else
					{
						arg.CinchHalf(
							

						);

					}



				}

				if (_s)
				{
					var sDiameter = arg1.current.Diameter();
					if (sDiameter == 0)
					{
						_s = false;
					}
					else
					{
						arg1.CinchHalf(
							

						);

					}



				}

			}

			return;



		}



		public override string ToString()
		{
			return $"{arg}{"+"}{arg1}";
		}
	}

}
