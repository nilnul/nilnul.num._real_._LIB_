using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.RealI;  //.RealI_posConverge2NonEmpty;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;

namespace nilnul.num.real.op_.unary_._exp
{


	public class Ret
		: R
	{
		private R _index;

		public R index
		{
			get { return _index; }
			set { _index = value; }
		}



		public Ret(R index)

		{
			this._index = index;

			var lowerOped = op_.unary_.Exp.RetRealI(_index.current.lower.mark);
			var upperOped = op_.unary_.Exp.RetRealI(_index.current.upper.mark);

			

			//var lowerBorder = new nilnul.num.quotient.Border2(
			//	_index.current.lower.openFalseCloseTrue && lowerOped.current.lower.openFalseCloseTrue,
			//	lowerOped.current.lower.mark
			//);

			//var upperBorder = new nilnul.num.quotient.Border2(
			//	_index.current.upper.openFalseCloseTrue
			//	&& upperOped.current.upper.openFalseCloseTrue
			//	,
			//	upperOped.current.upper.mark
			//);

			_bound = new q.bound_.Closed(
				lowerOped.current.lower.mark
				,
				upperOped.current.upper.mark
			);
		}



		private q.bound_.Closed _bound;

		public q.bound_.Closed current
		{
			get
			{




				return _bound;
				//throw new NotImplementedException();
			}
		}

		

		public void squeeze(nilnul.num.quotient_.Positive1 diameter)
		{
			var diameter_oneThird = diameter / (nilnul.num_.Positive1)3;

			while (
				current.diameterGt(diameter)
			)	/*this will execute at most one round*/
			{
				//below is unnecessary, as sup is clamped to the 1/3 of given diameter
				//_index.ClampHalf();/*in case against that the below remains no-op within each loop*/


				//var indexBound2b =; 
				_index.Clamp(
					 diameter_oneThird / current.upper.mark /*
					 the differential of e**x is e**x.
					 so re: the plot of e**x,
						when the diameter is the given value,
						the index must be within   the commented value
					we also need to take into account of the index-mapped value's approximation, so we use diameter_oneThird instead of diameter
					 */
				);

				var indexLowerExped = op_.unary_.exp_._OfQuotientX.RetRealI(_index.current.lower.mark);
				var indexUpperExped = op_.unary_.exp_._OfQuotientX.RetRealI(_index.current.upper.mark);


				indexLowerExped.Clamp(diameter_oneThird);
				indexUpperExped.Clamp(diameter_oneThird);

				//var lowerBorder = new nilnul.num.quotient.Border2(_index.current.lower.openFalseCloseTrue && indexLowerExped.current.lower.openFalseCloseTrue,
				//	indexLowerExped.current.lower.mark);

				//var upperBorder = new nilnul.num.quotient.Border2(
				//	_index.current.upper.openFalseCloseTrue
				//	&& indexUpperExped.current.upper.openFalseCloseTrue
				//	,
				//	indexUpperExped.current.upper.mark
				//);

				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					_bound
					,
					new q.bound_.Closed(
						indexLowerExped.current.lower.mark
						,
						indexUpperExped.current.upper.mark

					)
				);
			}
			//throw new NotImplementedException();
		}
	}
}
