using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using Q0 = nilnul.num.Quotient1;//.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Approach1 = nilnul.num._real.ApproachI1;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R1 = nilnul.num.RealI2;

using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num.quotient_;

namespace nilnul.num._real._cauchy.approach.op_.binary_._multi
{


	public partial class Ret
		:
		_call.ArgArg1
		,
		A
	{

		public Ret(A a, A b)
			: base(a, b)
		{
		}

		public Ret(Q0 a, A b)
			: this(
				new _real._cauchy.approach_.Quotient(a), b
			)
		{


		}
		public q.Range1 range =>  arg.range * arg1.range;
				

		public void squeeze(Positive1 diameter)
		{
			//if (arg.range.diameter==0)
			//{
			//	if (arg1.range.diameter !=0)
			//	{
			//		arg1.squeeze(
			//			new Positive1(
			//				range.diameter / 
			//			)

			//		);

			//	}
			//}
			//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

			bool _f = true, _s = true;

			while (range.diameter > diameter.en)
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
		}

		

		public override string ToString()
		{
			return $"{arg}{_MultiX.Sign}{arg1}";
		}
	}

}
