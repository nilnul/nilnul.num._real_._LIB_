using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using Rx = nilnul.num.real.all.RealX;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.real;
using nilnul.num.real.all;
using System.Numerics;

namespace nilnul.num
{
	[Obsolete()]
	static public class RealIX
	{

		static public R Sum(this IEnumerable<R> reals)
		{
			return (nilnul.num.real.set.to_._x._SumX.Sum_bisect(reals));
		}
		

		static public nilnul.num.real.be_.Positive.En ToPositiveReal(this Q q)
		{
			return new nilnul.num.real.be_.Positive.En(new nilnul.num.real_.Quotient(q)
				);
		}

		static public R Negate(this R x)
		{

			return nilnul.num.real.op_.Negate.lazy.eval(x);
		}
		static public R Negate(this nilnul.num.real.be_.Positive.En x)
		{

			return nilnul.num.real.op_.Negate.lazy.eval(x.val);
		}
		static public R Minus(this R x, R y)
		{

			return nilnul.num.real.duo.op_.Minus.Singleton.eval(x, y);
		}

		static public R Multi(this R x, R y)
		{

			return nilnul.num.real.duo.op_.Multi.Singleton.eval(x, y);
		}

		static public Real Multi(Q a, R b)
		{
			return new Real(

				nilnul.num.real.op_._ScaleX.Scale(a, b)

				);
		}

		static public bool Eq(this R x, R y)
		{

			return nilnul.num.real.Eq1.Eval(x, y);
		}

		static public bool NotEq(this R x, R y)
		{

			return !Eq(x, y);
		}

		static public R Square(this R r)
		{
			return nilnul.num.real.op_.Square.Singleton.eval(r);
		}
		static public Real Square1(this R r)
		{
			return nilnul.num.real.op_.Square.Singleton.eval(r).ToReal();
		}


		static public Real SquareX(this R r)
		{
			return new Real(nilnul.num.real.op_.Square.Singleton.eval(r));
		}

		static public bool NotZero(this R x)
		{

			return nilnul.num.real.be_.NotZero.Singleton.be(x);
		}
		static public R Half(this R x)
		{

			return nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(x, 2);
		}

		static public Real ToReal(this R x)
		{
			return new Real(x);
		}
		static public Real ToReal(this Q x)
		{
			return ( nilnul.num.Real)( x);
		}

		static public R ToRealI(this Q q)
		{
			return new nilnul.num.real_.Quotient(q);
		}
		static public bool IsInsideRange(this R r, nilnul.num.quotient.Range range)
		{

			var approach = r.choice.generate();
			return nilnul.num._real.approach.be_._InsideRangeX.LimitInsideRange(approach, range);



		}



		static public Q _Clamp_unitFracDenominator(this R r, int unitFracDen_positive)
		{
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit(unitFracDen_positive)
				)
			);
			return x.bound.midPoint;


		}

		static public Q _Clamp_unitFracDenominator(this R r, BigInteger unitFracDen_positive)
		{
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit(unitFracDen_positive)
				)
			);
			return x.bound.midPoint;


		}



		static public Q _ClampAsQ2DigitsAftDot(this R r, uint digitsAftDot)
		{
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit(
						nilnul.num.duo.op_.Pow.Do_basePlural_indexNonNeg(10, digitsAftDot)

					)
				)
			);
			return x.bound.midPoint;


		}

		static public num.quotient.radix.Dec _Clamp2Dec_DigitsAftDot(this R r, uint digitsAftDot)
		{
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit(
						nilnul.num.duo.op_.Pow.Do_basePlural_indexNonNeg(10, digitsAftDot)

					)
				)
			);

			return nilnul.num.quotient.radix.Dec.FroQuotient(x.bound.midPoint, digitsAftDot);


		}


		static public num.quotient.radix.recur.Dec _Clamp2DecRecur_DigitsAftDot(this R r, uint digitsAftDot)
		{
			var x = r.choice.generate();


			return nilnul.num.quotient.radix.recur.Dec._FroQuotient(

				_Clamp_unitFracDenominator(
					r,
					nilnul.num.duo.op_.Pow._Eval_basePlural_indexNonNeg(10, digitsAftDot)

				),

				digitsAftDot

				);


		}





	}
}
