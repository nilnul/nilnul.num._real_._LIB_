using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.Num1;
using R = nilnul.num.RealI;
using Q1 = nilnul.num.Quotient1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;

namespace nilnul.num.real_.nonneg.op_.unary_._sqrt.ret_.ofQuotient_
{


	public class PositiveLtOne
		: 
		RealI
	{
		private nilnul.num.quotient.be_.positive_.ltOne.vow.En _radicand;

		public nilnul.num.quotient.be_.positive_.ltOne.vow.En radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}



		public PositiveLtOne(
			nilnul.num.quotient.be_.positive_.ltOne.vow.En base_
		)

		{
			this._radicand = base_;

			_bound =new q.bound_.Closed(
				new num.Quotient1(
				
					_radicand.en
				)
				,
				1
			);

		}
		public PositiveLtOne(num.Quotient1 arg):this(new q.be_.positive_.ltOne.vow.En(arg))
		{
		}

		public PositiveLtOne(Quotient arg):this(arg.boxed)
		{
		}

		private q.bound_.Closed _bound;

		public q.bound_.Closed current
		{
			get
			{
				return _bound;
			//	throw new NotImplementedException();
			}
		}


		public void squeeze(num.quotient_.Positive1 diameter)
		{
			while (
				current.diameterGt(diameter)
			)
			{
				var middle = current.midPoint;

				var t = num.quotient.Comparer2.Singleton.Compare(
					nilnul.num.quotient.op_.unary_._SquareX.Square(middle)
					,
					_radicand.en
				);

				if (t == 0)
				{
					_bound = new q.bound_.Closed(middle);
				}
				else if (t > 0)
				{
					_bound =new q.bound_.Closed(
						_bound.lower.mark
						,
						middle

					);

				}
				else
				{
					_bound =new q.bound_.Closed(
						middle
						,
						_bound.upper.mark
					);
				}

			}

		}
	}
}
