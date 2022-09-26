using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;

using Q1 = nilnul.num.Quotient1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num._real_;
using q = nilnul.num.quotient;
using q_ = nilnul.num.quotient_;

namespace nilnul.num.real_.positive.cast_.sup_._ln.ret_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// The stream uses: <see cref="nameof(nilnul.num.quotient.series_.LnX)"/>
	/// 	
	/// 
	/// 	This is very slow for x approaching 2.
	/// </remarks>
	/// 

	public class OfQ
		: nilnul.num.RealI
	{
		private _ln.ret_._lnQuotient.terms.Series _series;
		public _ln.ret_._lnQuotient.terms.Series series
		{
			get { return _series; }
			set { _series = value; }
		}

		public OfQ(nilnul.num.quotient_.Positive1 arg)
		{

			_series = new _lnQuotient.terms.Series(arg);
			_one_minus_ySquared = 1 - _series.ySquared;
		}

		public OfQ(Q1 mark) : this(new q_.Positive1(mark))
		{
		}

		private Q1 _one_minus_ySquared;

		public Q1 one_minus_ySquared
		{
			get { return _one_minus_ySquared; }
		}
		public void squeeze(q_.Positive1 diameter)
		{
			var yAbs = nilnul.num.quotient.op_.unary_._AbsX.Op(_series.argDec_div_argInc);

			var ySquared = _series.ySquared;

			var n =

				 nilnul.num.quotient.op_.unary_._PolyX.AssumeIndexNat(yAbs, 5)
				/

				(diameter * (1 - ySquared))
				- nilnul.num.Quotient1.CreateHalf()

				;
			var nInteger = nilnul.num.quotient._CeilX.Ceil(n);

			//nInteger = BigInteger.Max(0, nInteger);


			nilnul.obj.stream_.slider._ForwardX.Forward(_series, nInteger);


			//throw new NotImplementedException();
		}


		/// <remarks>
		/// 
		/// The bound is calcuted in this way:
		/// 
		///  the remaining is : y^2n / (2n+1) + y^2(n+1) / (2(n+1)+1) +...
		///  Augment this to : y^2n / (2n+1) +y^2(n+1) / (2n+1) +...=y^2n/(1-y^2)
		///  Note: y will never be 1 since y=(1-x)/(1+x), where x never is 0.
		///  Note: y can be zero, when x is one. When y is 0, the bound is closed. May be we need to take out the speical case of x=1.
		/// </remarks>
		/// 
		public q.bound_.Closed current
		{
			get
			{
				return num.quotient.bound_.Closed.Create_orderIfNecessary(

					_series.current,

					_series.current
						+
					_series.toBeCumulated
					/
					_one_minus_ySquared
				);

				//	throw new NotImplementedException();
			}
		}

	}
}
