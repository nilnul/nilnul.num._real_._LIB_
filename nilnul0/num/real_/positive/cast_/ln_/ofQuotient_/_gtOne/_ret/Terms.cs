using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using N = nilnul._num.bigint.be.Positive.Asserted;
using Q1 = nilnul.num.Quotient1;
using q = nilnul.num.quotient;
using nilnul.num.quotient.stream.duo.op;
using nilnul.num.quotient;
using System.Numerics;

namespace nilnul.num.real_.positive.cast_.ln_.ofQuotient_._gtOne._ret
{


	/// <summary>
	/// expansiong of Ln(Q)
	/// </summary>
	public class Terms
		:
		q.stream_.SliderA1
		,
		nilnul.obj.stream_.slider_._FuncI
	{
		private q.stream_.SliderI1 _multiExpr;

		public q.stream_.SliderI1 multiExpr
		{
			get { return _multiExpr; }
		}

		q.stream_.slider_.Repeater repeater;
		q.stream_.slider_.geometric_.Std std;
		q.stream_.slider_.unital_.Odd odd;



		public override Q1 current => _multiExpr.current;

		public Terms(nilnul.num.quotient_.GtOne x)
		{
			var _y = (x - 1) / (x + 1);
			argDec_div_argInc = _y;

			ySquared = q.op_.unary_._SquareX.Square(_y);

			repeater = new q.stream_.slider_.Repeater(2 * _y);
			std = new q.stream_.slider_.geometric_.Std(ySquared);
			odd = new q.stream_.slider_.unital_.Odd();

			_multiExpr = q.stream_.slider.aggregate_._ProdX.Aggregate(
				repeater
				,
				std
				,
				odd

			);
			index = 0;
		}

		public Terms(nilnul.num.QuotientI1 q):this(new num.quotient_.GtOne(q))
		{

		}
		public nilnul.num.Quotient1 ySquared;
		public nilnul.num.Quotient1 argDec_div_argInc;

		public BigInteger index;


		public override void moveNext()
		{
			index++;
			_multiExpr.moveNext();
		}

		public void setIndex(Num1 num)
		{
			index = num;
			repeater.setIndex(num);
			std.setIndex(num);
			odd.setIndex(num);
			//throw new NotImplementedException();
		}

		public void moveNext(Num1 num)
		{
			index += num;
			repeater.moveNext(num);
			std.moveNext(num);
			odd.moveNext(num);

		}
	}
}