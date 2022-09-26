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

using R = nilnul.num.RealI;
using nilnul.num.quotient_;

namespace nilnul.num.real.op_.binary_._multi
{

	public partial class Ret
		:
		_call_.ArgArg1
		,
		R
	{

		public Ret(R a, R b)
			: base(a, b)
		{
		}
		public Ret(real_.Quotient a, R b)
			: this(
				(RealI)(a), b
			)
		{
		}

		public Ret(Q0 a, R b)
			: this(
				new real_.Quotient(a), b
			)
		{
		}
		public q.bound_.Closed current => arg.current * arg1.current;


		public void squeeze(Positive1 diameter)
		{
			//if (arg.bound.diameter==0)
			//{
			//	if (arg1.bound.diameter !=0)
			//	{
			//		arg1.squeeze(
			//			new Positive1(
			//				bound.diameter / 
			//			)

			//		);

			//	}
			//}
			//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

			bool _f = true, _s = true;

			while (current.diameter >= diameter.en)
			{
				var fDiameter = arg.current.diameter;
				var sDiameter = arg1.current.diameter;

				if (fDiameter == 0)
				{
					arg1.Clamp1K();
				}
				else
				{
					if (sDiameter == 0)
					{
						arg.Clamp1K();
					}
					else
					{
						var sum = fDiameter + sDiameter;

						var first = fDiameter / sum;
						var second = sDiameter / sum;

						var totalCount = 1024;
						var min = 16;

						var firstTimes = totalCount * first.en;
						if (firstTimes < min)
						{
							firstTimes = min;
						}

						var secondTimes = totalCount * second.en;
						if (secondTimes < min)
						{
							secondTimes = min;
						}

						arg.squeeze(
							new quotient_.Positive1(
								fDiameter / firstTimes

							)

						);
						arg1.squeeze(
							new quotient_.Positive1(
								sDiameter / secondTimes

							)
						);

					}
				}



			}
		}




		public override string ToString()
		{
			return $"{arg}{Multi.Sign}{arg1}";
		}
	}

}
