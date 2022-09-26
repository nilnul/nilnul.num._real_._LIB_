using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.band_._log._ofPositiveQuotients
{
	public class Ret
		:nilnul.num.RealI
		
	{
		private nilnul.num.quotient_.positive_.NeOne _sub;

		public nilnul.num.quotient_.positive_.NeOne sub
		{
			get { return _sub; }
			set { _sub = value; }
		}

		private nilnul.num.quotient_.Positive1 _target;

		public nilnul.num.quotient_.Positive1 target
		{
			get { return _target; }
			set { _target = value; }
		}

		private Closed _current;
		public Closed current => _current;

		public Ret(
			nilnul.num.quotient_.positive_.NeOne sub
			,
			nilnul.num.quotient_.Positive1 target
		)
		{
			_sub = sub;
			_target = target;
		}

		public void squeeze(Positive1 diameter)
		{
			/// supposing diameter is q/p
			/// 
			///  q/p * Log(s^q,t^p)=  log(s, t)
			///  
			/// so
			///
			/// var newTarget = nilnul.num.quotient.op_.unary_.Poly.Eval( _target , diameter.en.denominator1);

			//var newSub= nilnul.num.quotient.op_.unary_.Poly.Eval( _sub , diameter.en.numerator);

			///we then find a whole number in  a bound of length (  )
			///
			///var lengthOfBound = diameter.en.numerator;

			var bound = nilnul.num.quotient.co_.startPositiveNeOne._LogX.Bound(
				nilnul.num.quotient.op_.unary_.Poly.Eval( _sub , diameter.en.numerator)
				,
				nilnul.num.quotient.op_.unary_.Poly.Eval(_target, diameter.en.denominator1)
			);

			_current = num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
				_current
				,
				diameter
				*
				new nilnul.num.quotient.bound_.Closed(
					bound.lower.mark
					,
					bound.upper.mark
				)
			);

			/// for log (sub, newTarget), we find a real "x" converged into bound of LengthOfBound
			/// the value we want is :
			///		x/ diameter.en.Denominator

			//	throw new NotImplementedException();
		}
	}
}
