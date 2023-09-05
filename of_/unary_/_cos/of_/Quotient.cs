using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using A = nilnul.num.RealI;
using q = nilnul.num.quotient;

using q_ = nilnul.num.quotient_;
using nilnul.num.quotient;

using nilnul.num.quotient_;
using System.Numerics;

namespace nilnul.num.real.op_.unary_._cos.of_
{
	public class QuotientNotNil
		:
		A
	{
		private _quotient.Cumulus _series;

		public _quotient.Cumulus series
		{
			get { return _series; }
			//set { _series = value; }
		}


		public QuotientNotNil(Q1 arg)
		{
			_series = new _quotient.Cumulus(arg);
			var argAbs = arg*arg;	//the rate
			for (BigInteger i = 0; i <= argAbs; i += 2)
			{
				_series.moveNext();

			}



			_bound = nilnul.num.quotient.bound_.closed_._CenteredX.CreateClosed(
				_series.current
				,
				nilnul.num.quotient_.positive.op_.nary_._AbsX.Op(_series.nextAugend)
			);
		}

		q.bound_.Closed _bound;
		public q.bound_.Closed current => _bound;

		//throw new NotImplementedException();


		public void squeeze(quotient_.Positive1 diameter)
		{
			while (_bound.isNotDiameterLt(diameter))
			{
				///todo: this can be finetuned by reverse engineering the bound expr of x.
				///
				for (int i = 0; i < 100; i++)
				{
					_series.moveNext();

				}

				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					_bound
					,
nilnul.num.quotient.bound_.closed_._CenteredX.CreateClosed(
	_series.current,
					  nilnul.num.quotient_.positive.op_.nary_._AbsX.Op(_series.nextAugend)
				)

				);


			}

		}

	}
}
