using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using N = nilnul._num.bigint.be.Positive.Asserted;
using Q1 = nilnul.num.Quotient1;
using q = nilnul.num.quotient;
using r = nilnul.num.real;
using nilnul.num.quotient.stream.duo.op;
using nilnul.num.quotient;
using System.Numerics;

namespace nilnul.num.real.stream_.slider.series_._ln
{


	/// <summary>
	/// expansiong of Ln(Q)
	/// </summary>
	public class Slider
		:
		nilnul.num.real.stream_.SliderA
		,
		nilnul.obj.stream_.slider_._FuncI
	{
		private nilnul.num.real.stream_.SliderI _multiExpr;

		public nilnul.num.real.stream_.SliderI multiExpr
		{
			get { return _multiExpr; }
		}

		real.stream_.slider_.Repeater repeater;
		quotient.stream_.slider_.unital_.Odd _odd;
		real.stream_.slider_.Quotient odd;
		real.stream_.slider_.geometric_.Std std;





		public override nilnul.num.RealI current => _multiExpr.current;

		public Slider(nilnul.num.real_.Positive x)
		{
			var _y = (x.en.ToReal() - 1) / (x.en.ToReal() + 1);
			argDec_div_argInc = _y;

			ySquared =  real.op_.unary_._SquareX.Op(_y);

			repeater = new real.stream_.slider_.Repeater(2 * _y);
			std = new real.stream_.slider_.geometric_.Std(ySquared);
			_odd = new q.stream_.slider_.unital_.Odd();
			odd = new real.stream_.slider_.Quotient( _odd );

			_multiExpr = r.stream_.slider.op_.binary_.multi.Cumulator.Singleton.accumulate(
				repeater
				,
				odd
				,
				std

			);
			index = 0;
		}

		public Slider(RealI q):this( new nilnul.num.real_.Positive(q))
		{

		}

		public nilnul.num.RealI ySquared;
		public nilnul.num.RealI argDec_div_argInc;

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
			_odd.setIndex(num);
			//throw new NotImplementedException();
		}

		public nilnul.num.RealI geometricTerm {
			get {
				return std.current;
			}
		}

		public void moveNext(Num1 num)
		{
			index += num;
			repeater.moveNext(num);
			std.moveNext(num);
			_odd.moveNext(num);

		}
	}
}