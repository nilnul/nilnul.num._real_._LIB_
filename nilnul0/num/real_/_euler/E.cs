using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using q = nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach_
{
	/// <summary>
	/// 
	/// </summary>
	public class E

		:
			ApproachI1
	{



		private _e.Lag _seriesLookAhead;

		public _e.Lag seriesLookAhead
		{
			get { return _seriesLookAhead; }
			//set { _seriesLookAhead = value; }
		}


		private nilnul.num.quotient.border.duo.be_.Nonempty.En _exp0_x;

		public nilnul.num.quotient.border.duo.be_.Nonempty.En exp0_x
		{
			get { return _exp0_x; }
			//set { _exp0_x = value; }
		}

		public E()
		{


			_exp0_x = Nonempty.En.CreateOpen(
				1,
				3
			);

			_seriesLookAhead = new _e.Lag();

		}

		public Nonempty.En bound
		{
			get
			{

				return nilnul.num.quotient.range.op_.Shift.Eval(

					_seriesLookAhead.accumulated
					,
					_seriesLookAhead.nextAugend * _exp0_x   // [the n+1 th derivative of (e^y)]  * (x-0)^(n+1) /(n+1)!, where y is in [0, x]. 

				);
			}
		}

		public void clamp(Positive1.En diameter)
		{

			while (
				bound.notSpanLessThan(diameter)

			)
			{
				_seriesLookAhead.moveNext();
			}

		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
