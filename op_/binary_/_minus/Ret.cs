using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient_;
using nilnul.num.quotient;

namespace nilnul.num._real._cauchy.approach.op_.binary_._minus
{
	public class Ret
		:
		nilnul._call.argArg1_.Closed<ApproachI>
		,
		A
	{


		public Ret(A a, A b)
			: base(a, b)
		{


		}


		public Range1 range =>
					 arg.range - arg1.range;



		public void squeeze(Positive1 diameter)
		{


			//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

			bool _f = true, _s = true;

			while (range.notSpanLessThan(diameter))
			{
				if (_f)
				{
					var fDiameter = arg.range.diameter;
					if (fDiameter == 0)
					{
						_f = false;
					}
					else
					{
						arg.squeeze(
							new quotient_.Positive1(
							fDiameter / 2
							)

						);

					}



				}

				if (_s)
				{
					var sDiameter = arg1.range.diameter;
					if (sDiameter == 0)
					{
						_s = false;
					}
					else
					{
						arg1.squeeze(
							new quotient_.Positive1(
							sDiameter / 2
							)

						);

					}



				}

			}

			return;
			//	throw new NotImplementedException();



		}



		public override string ToString()
		{
			return $"{arg}{Add.Sign}{arg1}";
		}
	}

}
