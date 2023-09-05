using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using q = nilnul.num.quotient;
using q_ = nilnul.num.quotient_;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using Q1 = nilnul.num.Quotient1;//;
using System.Numerics;

namespace nilnul.num.real.op_.unary_._sin.ret_
{
	public class OfQuotientNonnil
		:

		nilnul.num.RealI
	{
		private _ofQuotient.Cumulus _series;

		public _ofQuotient.Cumulus series
		{
			get { return _series; }
			//set { _series = value; }
		}


		public OfQuotientNonnil(Q1 arg)
		{
			_series = new _ofQuotient.Cumulus(arg);
			var argAbs = arg*arg;

			for (BigInteger i = 1; i <= argAbs; i += 2)
			{
				_series.moveNext();

			}

			//while (_series.nextAugend.Abs() >= argAbs)
			//{
			//	_series.moveNext();
			//}

			_bound = nilnul.num.quotient.bound_.closed_._CenteredX.CreateClosed(
				_series.current
				,
				nilnul.num.quotient_.positive.op_.nary_._AbsX.Op(_series.nextAugend)
			);
		}
		private q.bound_.Closed _bound;
		public q.bound_.Closed current => _bound;

		public void squeeze(quotient_.Positive1 diameter)
		{
			var tBound = this._bound;

			while (tBound.isNotDiameterLt(diameter))
			{
				///todo: this can be finetuned by reverse engineering the bound expr of x.
				///
				for (int i = 0; i < 10; i++)
				{
					_series.moveNext();

				}

				tBound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					 tBound
					 ,
					 num.quotient.bound_.closed_._CenteredX.CreateClosed(

						_series.current
						,

						 nilnul.num.quotient_.positive.op_.nary_._AbsX.Op(_series.nextAugend)
					)
				);
			}

			_bound = tBound;

			//throw new NotImplementedException();
		}

	}
}
