using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;



namespace nilnul.num._real.approach
{



	/// <summary>
	/// A real number
	/// </summary>
	/// 
	[Obsolete()]
	public static class X
	{



		static public void ClampHalf(this _real.ApproachI1 x)
		{
			if (x.bound.diameter !=0)
			{
			x.clamp(new nilnul.num.quotient.be_.Positive1.En(x.bound.diameter / 2));

			}

		}

		static public void ClampOneThird(this _real.ApproachI1 x)
		{
			x.clamp(new nilnul.num.quotient.be_.Positive1.En(x.bound.diameter / 3));

		}

		static public void Clamp1K(this _real.ApproachI1 x)
		{
			x.clamp(new nilnul.num.quotient.be_.Positive1.En(x.bound.diameter /1024));

		}

		static public void Clamp(this _real.ApproachI1 x, int i)
		{
			x.clamp(new nilnul.num.quotient.be_.Positive1.En(i));

		}


		static public void Clamp(this _real.ApproachI1 x, Q1 i)
		{
			x.clamp(new nilnul.num.quotient.be_.Positive1.En(i));

		}




		static public void _Clamp2UnitFrac(this _real.ApproachI1 x, BigInteger denominator_positive)
		{
			x.clamp(

				nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(
						new nilnul._num.bigint.be.Positive.Asserted(
							denominator_positive
						)

				)
			);

		}

		static public void _Clamp2DigitsAftDot(this _real.ApproachI1 x, BigInteger digitsAftDot)
		{
			x._Clamp2UnitFrac(
				nilnul.num.op.Pow.Do_basePlural_indexNonNeg(10,digitsAftDot)

				
			);

		}







	}//class

}//namespace




