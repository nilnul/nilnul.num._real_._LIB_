using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using R = nilnul.num.RealI;//.real.RealI_posConverge2NonEmpty;
using A = nilnul.num.RealI;//.real.RealI_posConverge2NonEmpty;

using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.border.duo.be_;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient_;
using nilnul.num.quotient;

namespace nilnul.num.real.op_.binary_._add
{

	public class Ret
		:
		nilnul.num.real._call_.ArgArg1
		,
		R
	{





		public Ret(R a, A b)
			: base(a, b)
		{


		}
		public Ret(nilnul.num.real_.Quotient a, A b)
			: this(
				(R)(a), b
			)
		{


		}

		public Ret(Q0 a, A b)
			: this(
				new real_.Quotient(a), b
			)
		{


		}
		public num.quotient.bound_.Closed current =>
					 arg.current + arg1.current;


		public void squeeze(Positive1 diameter)
		{


			//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

			bool _f = true, _s = true;

			while (current.diameterGt(diameter))
			{
				if (_f)
				{
					var fDiameter = arg.current.diameter;
					if (fDiameter == 0)
					{
						_f = false;
					}
					else
					{
						arg.squeeze(
							new quotient_.Positive1(
							fDiameter / 1024
							)

						);

					}



				}

				if (_s)
				{
					var sDiameter = arg1.current.diameter;
					if (sDiameter == 0)
					{
						_s = false;
					}
					else
					{
						arg1.squeeze(
							new quotient_.Positive1(
							sDiameter / 1024
							)

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
