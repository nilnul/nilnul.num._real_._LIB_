using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using q = nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num.Quotient1;
using R = nilnul.num.Real;

namespace nilnul.num.real.op_.unary_._exp.ret_.ofQuotient_
{
	/// <summary>
	/// 
	/// </summary>
	public class OfPositive

		:
			nilnul.num.RealI
	{



		private _ofPositive.Series _seriesLookAhead;

		public _ofPositive.Series seriesLookAhead
		{
			get { return _seriesLookAhead; }
			//set { _seriesLookAhead = value; }
		}



		public OfPositive(nilnul.num.quotient_.Positive1 index)
		{


			_exp0_x = q.bound_.Closed.Create_orderIfNecessary(
				1,
				nilnul.num.quotient.op_.unary_.Poly.Eval(
					3
					,
					q.cast_._ExpandX.Expand(
						index
					)
				)
			);

			_seriesLookAhead = new _ofPositive.Series(index);

			_bound = _exp0_x;


			/*
			 [the (n+1)th derivative of (e^t)] at x`
			  *
			  (x-x0)^(n+1) /(n+1)!, where x` is in [x0, x].

		   */



		}
		public OfPositive(Q1 index):this(new quotient_.Positive1(index))
		{
		}


		private nilnul.num.quotient.bound_.Closed _exp0_x;

		public nilnul.num.quotient.bound_.Closed exp0_x
		{
			get { return _exp0_x; }
			//set { _exp0_x = value; }
		}

		private q.bound_.Closed _bound;
		public q.bound_.Closed current
		{
			get
			{
				return _bound;

			}
		}


		public void squeeze(nilnul.num.quotient_.Positive1 diameter)
		{

			while (
				_bound.diameterGt(diameter)

			)
			{
				//for (int i = 0; i < 1000; i++)
				//{
					_seriesLookAhead.move();

				//}
				var newBound = nilnul.num.quotient.bound_.closed.op_.unary_._ShiftX.Op(

					_seriesLookAhead.accumulated
					,
					_seriesLookAhead.buffer.Last() * _exp0_x   ///
				/*
				 [the (n+1)th derivative of (e^t)] at x`
				  *
				  (x-x0)^(n+1) /(n+1)!, where x` is in [x0, x].

			   */

				);
				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(_bound, newBound); //ensure nested
			}

		}
	}
}
