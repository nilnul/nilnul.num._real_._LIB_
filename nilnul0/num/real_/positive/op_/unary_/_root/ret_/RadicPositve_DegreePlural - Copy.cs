using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;

namespace nilnul.num.real_.positive.op_.unary_._root.ret_
{

	public class DegreePlural
		: 
		nilnul.num.RealI
	{
		private real_.Positive1 _radicand;
		public real_.Positive1 radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}

		private nilnul.num_.Plural _degree;
		public nilnul.num_.Plural degree
		{
			get { return _degree; }
			set { _degree = value; }
		}



		public DegreePlural(
			real_.Positive1 radicand
			,
			nilnul.num_.Plural degree
			
			)

		{
			this._radicand = radicand;
			this._degree = degree;



			var lowerRooted = nonneg.op_.unary_._RootX.RetRealI(radicand.bound.lower.mark, degree);
			var upperRooted = nonneg.op_.unary_._RootX.RetRealI(radicand.bound.upper.mark, degree);


			var lowerBorder = new nilnul.num.quotient.Border2( radicand.bound.lower.openFalseCloseTrue && lowerRooted.bound.lower.openFalseCloseTrue , lowerRooted.bound.lower.mark  );


			var upperBorder=  new nilnul.num.quotient.Border2( 
				radicand.bound.upper.openFalseCloseTrue
				&& upperRooted.bound.upper.openFalseCloseTrue 
				, 
				upperRooted.bound.upper.mark 
			);



			_bound = new num.quotient.Bound(lowerBorder, upperBorder);





		}


		private num.quotient.Bound _bound;
		public num.quotient.Bound bound
		{
			get
			{
				return _bound;
			}
		}


		public void squeeze(num.quotient_.Positive1 diameter)
		{
			
			var diameter_oneThird = diameter / (nilnul.num_.Positive1)3;


			while (

				bound.notSpanLessThan(diameter)


				)
			{

				radicand.ClampHalf(

					
				);

				var lowerRooted = nonneg.op_.unary_._RootX.RetRealI(radicand.bound.lower.mark, degree);
				var upperRooted = nonneg.op_.unary_._RootX.RetRealI(radicand.bound.upper.mark, degree);

				
					lowerRooted.Clamp(diameter_oneThird);
					upperRooted.Clamp(diameter_oneThird);
				

				var lowerBorder = new nilnul.num.quotient.Border2(radicand.bound.lower.openFalseCloseTrue && lowerRooted.bound.lower.openFalseCloseTrue, lowerRooted.bound.lower.mark);


				var upperBorder = new nilnul.num.quotient.Border2(
					radicand.bound.upper.openFalseCloseTrue
					&& upperRooted.bound.upper.openFalseCloseTrue
					,
					upperRooted.bound.upper.mark
				);




				_bound = new num.quotient.Bound(lowerBorder, upperBorder);



			}

		}


	}
}
