using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using A = nilnul.num.RealI; // ._real._cauchy.ApproachI;
using R = nilnul.num.RealI; // ._real._cauchy.ApproachI;

namespace nilnul.num
{

	/// <summary>
	/// A real number
	/// </summary>
	/// 
	public static class RealIX
	{
		static public void ClampHalf(this A x)
		{
			if (x.current.diameter != 0)
			{
				x.squeeze(new nilnul.num.quotient_.Positive1(x.current.diameter / 2));
			}
		}

		static public void ClampOneThird(this A x)
		{
			if (x.current.diameter != 0)
			{
				x.squeeze(new nilnul.num.quotient_.Positive1(x.current.diameter / 3));
			}

		}
		static public void Clamp(this A x, Q1 i)
		{
			if (x.current.diameter1 == 0)
			{
				return;
			}
			x.squeeze(new nilnul.num.quotient_.Positive1(i));

		}

		static public void ClampRatio(this A x, nilnul.num.quotient_.positive_.LtOne ratio)
		{
			if (x.current.diameter != 0)
			{
				x.Clamp((x.current.diameter.en *ratio));
			}
		}
		static public void _ClampRatio_assumeRatioPositive(this A x, nilnul.num.Quotient1 ratio)
		{
			if (ratio>=1)
			{
				return;
			}
			x.ClampRatio( new quotient_.positive_.LtOne(ratio) );
		}


		static public void Clamp1K(this A x)
		{
			if (x.current.diameter != 0)
			{
				x.squeeze(new nilnul.num.quotient_.Positive1(x.current.diameter / 1024));
			}

		}

		static public void Clamp(this A x, int i)
		{
			if (x.current.diameter == 0)
			{
				return;
			}
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
				nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(10, digitsAftDot)


			);

		}

		/// <summary>
		/// make the real number's precision 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="precision"></param>
		static public void _Clamp_assumePrecisionPositive(this R r, R precision)
		{

			// make it positive.
			nilnul.num.real_._positive._Clamp_ofAssumePositiveX.Clamp4LowerPositive_assumePositive(precision);

			if (r.current.diameter==0)
			{
				return;
			}

			var halfDiameterOfReal = r.current.diameter / 2;
			//
			if ( precision.current.diameter > halfDiameterOfReal )
			{
				precision.Clamp(halfDiameterOfReal);
			}
			r.Clamp(precision.current.lower.mark);

		}
		static public Real ToReal(this RealI x)
		{
			return  Real.Ov(x);
		}

		static public Real ToReal(this Q1 q)
		{
			return new nilnul.num.real_.Quotient(q);
		}

		static public nilnul.num.real_.Positive ToPositiveReal(this Q1 q)
		{
			return new nilnul.num.real_.Positive(new nilnul.num.real_.Quotient(q)
				);
		}

		static public R Negate(this R x)
		{

			return nilnul.num.real.op_.unary_.Neg.Singleton.op(x);
		}
		static public R Negate(this nilnul.num.real_.Positive x)
		{

			return nilnul.num.real.op_.unary_.Neg.Singleton.op(x);
		}
		static public R Minus(this R x, R y)
		{

			return nilnul.num.real.op_.binary_.Minus.Singleton.op(x, y);
		}

		static public R Multi(this R x, R y)
		{

			return nilnul.num.real.op_.binary_.Multi.Singleton.op(x, y);
		}

		static public Real Multi(Q1 a, R b)
		{
			return new Real(

				nilnul.num.real.op_.unary_._ScaleX.Scale(a, b)

				);
		}

		static public bool Eq(this R x, R y)
		{

			return nilnul.num.real.Eq.Singleton.Equals(x, y);
		}

		static public bool NotEq(this R x, R y)
		{

			return !Eq(x, y);
		}

		static public R Square(this R r)
		{
			return nilnul.num.real.op_.unary_.Square.Singleton.op(r);
		}



		static public Real SquareAsReal(this R r)
		{
			return new Real(Square(r));
		}

		static public RealI Abs(this R r)
		{
			return nilnul.num.real.op_.unary_.Abs.Singleton.op(r);
		}

		static public bool BeNonnil(this R x)
		{

			return nilnul.num.real.be_.nil.Anto.Singleton.be(x);
		}
		static public R Half(this R x)
		{

			return nilnul.num.real.op_.unary_._ScaleX.Halve(x);
		}


		//static public bool IsInsideRange(this R r, nilnul.num.quotient.Bound range)
		//{

		//	var approach = r.choice.generate();
		//	return nilnul.num._real.approach.be_._InsideRangeX.LimitInsideRange(approach, range);



		//}



	}//class

}//namespace




