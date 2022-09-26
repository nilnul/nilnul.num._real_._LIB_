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
using nilnul.num.real_;
using nilnul.num.quotient.bound_;
using nilnul.obj.stream_._slider._cursor_;

namespace nilnul.num.real.stream_.slider.series_.ln
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

	public class Limit
		:

		nilnul.num.RealI
		,
		nilnul.num.real.stream_.bounded_.CauchyI
		,
		nilnul.num.quotient.bound_.closed.stream_.nested_._cauchy_.ClampI1
	{
		private series_.Ln _series;
		public series_.Ln series
		{
			get { return _series; }
			set { _series = value; }
		}

		public Limit(nilnul.num.real_.Positive arg)
		{

			_series = new series_.Ln(arg);
			_one_minus_ySquared = 1 - _series.argDecDivArgInc_Squared.ToReal();
			_yAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op(
				_series.argDec_div_argInc
			);
			_setBound();
		}

		public Limit(Q1 mark) : this(new real_.Positive(mark))
		{
		}

		private Real _one_minus_ySquared;

		public Real one_minus_ySquared
		{
			get { return _one_minus_ySquared; }
		}

		private RealI _yAbs;

		public RealI yAbs
		{
			get { return _yAbs; }
		}


		[Obsolete()]
		public void squeeze(q_.Positive1 diameter)
		{
			clamp(diameter);


			//throw new NotImplementedException();
		}
		public void clamp(q_.Positive1 diameter)
		{

			this.Clamp(diameter/2);
		}

		public RealI next()
		{
			return series.next();
		}



		public void squeeze(real_.PositiveI diameter)
		{
			//var yAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op(_series.argDec_div_argInc);

			//var ySquared = _series.ySquared;

			/*
			 
			 let y := x-- / x++
			then
					2*y / (2n+1) * (y^2n)
					/
					(1-y^2)
				is the residue, including this term
			we need the residue <= given d

			 that is , we need:
				n >= [ 2y*y^2n / d(1-y^2)  -1 ] /2
			now that we are currently at k,
			and we need to move to n such that n >= [ 2y*y^2n / d(1-y^2)  -1 ] /2

			if we let n >= [ 2y*y^2k / d(1-y^2)  -1 ] /2, then we have n >= [ 2y*y^2n / d(1-y^2)  -1 ] /2, becuz y isin (0,1)
				for :  n >= [ 2y*y^2k / d(1-y^2)  -1 ] /2
			we solve : n >=  y*y^2k / d(1-y^2) -1/2

			 */

			var n = _yAbs.ToReal()  *_series.geometricTerm
				/
				(diameter * one_minus_ySquared)
				-
				nilnul.num.Quotient1.CreateHalf()

				;
			var nInteger = nilnul.num.real.to_.int_._GeDistanceLtTwoX.NonSmallerLtTwo(n);

			nilnul.obj.stream_.slider._ForwardX.Forward(_series, nInteger);
			_setBound();
		}

		void _setBound()
		{
			_bound = new num.real.bound_.closed_.Based(
				_series.current
				,
				_series.toBeCumulated.ToReal()
				/
				_one_minus_ySquared
			);
		}


		real.Bound1 _bound;

		//public Bound1 bound => throw new NotImplementedException();

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
		public real.Bound1 bound
		{
			get
			{
				return _bound;

				//	throw new NotImplementedException();
			}
		}

		public q.bound_.Closed current
		{
			get
			{
				return nilnul.num.real.bound_.spanned_.disengaged.OuterOvDiameterX.Outer_assumeSpanned(_bound
					,
					2
				);
			}
		}
	}
}
