using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using A = nilnul.num._real._cauchy.ApproachI;



namespace nilnul.num._real._cauchy
{



	/// <summary>
	/// A real number
	/// </summary>
	/// 
	public static class ApproachIX
	{



		static public void ClampHalf(this A x)
		{
			if (x.range.diameter !=0)
			{
				x.squeeze(new nilnul.num.quotient_.Positive1(x.range.diameter / 2));

			}

		}

		static public void ClampOneThird(this A x)
		{
			x.squeeze(new nilnul.num.quotient_.Positive1(x.range.diameter / 3));

		}

		static public void Clamp1K(this A x)
		{
			x.squeeze(new nilnul.num.quotient_.Positive1(x.range.diameter /1024));

		}

		static public void Clamp(this A x, int i)
		{
			x.squeeze(new nilnul.num.quotient_.Positive1(i));

		}


		static public void Clamp(this A x, Q1 i)
		{
			x.squeeze(new nilnul.num.quotient_.Positive1(i));

		}




		static public void _Clamp2UnitFrac(this A x, BigInteger denominator_positive)
		{

			Clamp(x, 
				nilnul.num.Quotient1.CreateUnit(denominator_positive)
			);
			

		}

		static public void _Clamp2DigitsAftDot(this A x, BigInteger digitsAftDot)
		{
			x._Clamp2UnitFrac(
				nilnul.num.op.Pow.Do_basePlural_indexNonNeg(10,digitsAftDot)

				
			);

		}







	}//class

}//namespace




