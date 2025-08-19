using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using R = nilnul.num.RealI6;//.real.RealI_posConverge2NonEmpty;
//using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient_;
using nilnul.num.quotient;
using A = nilnul.num.RealI6;
//using R = nilnul.num.RealI6;

namespace nilnul.num.real.op_.binary_._add
{

	public class Ret1
		:
		nilnul.num.real._call_.ArgArg1_1
		,
		R
	{





		public Ret1(A a, A b)
			: base(a, b)
		{


		}
		public Ret1(Q0 a, A b)
			: this(
				new real_.Quotient2(a), b
			)
		{


		}

		public Ret1(real_.Quotient2 a, A b)
			: this(
				(A)(a), b
			)
		{


		}
		public nilnul.num.quotient.Bound bound =>
					 arg.bound + arg1.bound;



		public void squeeze(Positive1 diameter)
		{


			//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

			bool _f = true, _s = true;

			while (bound.notSpanLessThan(diameter))
			{
				if (_f)
				{
					var fDiameter = arg.bound.diameter;
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
					var sDiameter = arg1.bound.diameter;
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
