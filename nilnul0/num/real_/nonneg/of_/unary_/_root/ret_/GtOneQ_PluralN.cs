using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using R = nilnul.num.RealI;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num._real_;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num.real_.nonneg.op_.unary_._root.ret_
{


	public class GtOneQ_PluralN
		: 
		RealI
	{
		private nilnul.num.quotient.be_.gtOne.vow.En _radicand;

		public nilnul.num.quotient.be_.gtOne.vow.En radicand
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



		public GtOneQ_PluralN(
			nilnul.num.quotient.be_.gtOne.vow.En base_,
			nilnul._num.bigint.be_.Plural.En degree
			
			)

		{
			this._radicand = base_;
			this._degree = degree;

			_bound = new num.quotient.bound_.Closed(
				1,
				new num.Quotient1(
				(_radicand).en
				)
			);

		}

	

		private nilnul.num.quotient.bound_.Closed _bound;



		public num.quotient.bound_.Closed current => _bound;


		public void squeeze(num.quotient_.Positive1 diameter)
		{
			
			while (

				current.diameterGt(diameter)

				//_accuracy.isNotSubSetOf(accuracy)

				)
			{

				var middle = current.midPoint;// _rationalCompute();

				var powered = nilnul.num.quotient.op_.unary_.Poly.Eval(middle, degree);

				var t = num.quotient.Comparer2.Singleton.Compare(powered, _radicand.en);

				if (t == 0)
				{
					_bound = new num.quotient.bound_.Closed(middle);

				}
				else if (t > 0)
				{
					_bound = new num.quotient.bound_.Closed(
						_bound.lower.mark
						,
						middle

					);

				}
				else
				{
					_bound = new num.quotient.bound_.Closed(
						middle
						,
						_bound.upper.mark
					);
				}

			}

			//throw new NotImplementedException();
		}

	}
}
