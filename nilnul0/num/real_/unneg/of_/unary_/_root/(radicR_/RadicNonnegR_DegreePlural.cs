using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.real.op;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.op_._root.ret_
{

	public class RadicNonnegR_DegreePlural
		: 
		ApproachI1
	{
		private approach.be_.Nonneg.En _radicand;
		public approach.be_.Nonneg.En radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}

		private nilnul._num.bigint.be_.Plural.En _degree;
		public nilnul._num.bigint.be_.Plural.En degree
		{
			get { return _degree; }
			set { _degree = value; }
		}



		public RadicNonnegR_DegreePlural(
			approach.be_.Nonneg.En radicand,
			nilnul._num.bigint.be_.Plural.En degree
			
			)

		{
			this._radicand = radicand;
			this._degree = degree;



			var lowerRooted = op_.Root.Eval(radicand.bound.lower.mark, degree);
			var upperRooted = op_.Root.Eval(radicand.bound.upper.mark, degree);


			var lowerBorder = new nilnul.num.quotient.Border1( radicand.bound.lower.openFalseCloseTrue && lowerRooted.bound.lower.openFalseCloseTrue , lowerRooted.bound.lower.mark  );


			var upperBorder=  new nilnul.num.quotient.Border1( 
				radicand.bound.upper.openFalseCloseTrue
				&& upperRooted.bound.upper.openFalseCloseTrue 
				, 
				upperRooted.bound.upper.mark 
			);




			_bound = new Nonempty.En(lowerBorder, upperBorder);





		}


		private Nonempty.En _bound;
		public Nonempty.En bound
		{
			get
			{
				return _bound;
			}
		}

		

		public void clamp(Positive1.En diameter)
		{

			var diameter_oneThird = diameter / (nilnul._num.bigint.be.Positive.Asserted)3;


			while (

				bound.notSpanLessThan(diameter)


				)
			{

				radicand.ClampHalf(

					
				);

				var lowerRooted = op_.Root.Eval(radicand.bound.lower.mark, degree);
				var upperRooted = op_.Root.Eval(radicand.bound.upper.mark, degree);

				
					lowerRooted.Clamp(diameter_oneThird);
					upperRooted.Clamp(diameter_oneThird);
				

				var lowerBorder = new nilnul.num.quotient.Border1(radicand.bound.lower.openFalseCloseTrue && lowerRooted.bound.lower.openFalseCloseTrue, lowerRooted.bound.lower.mark);


				var upperBorder = new nilnul.num.quotient.Border1(
					radicand.bound.upper.openFalseCloseTrue
					&& upperRooted.bound.upper.openFalseCloseTrue
					,
					upperRooted.bound.upper.mark
				);




				_bound = new Nonempty.En(lowerBorder, upperBorder);



			}

		}
	}
}
