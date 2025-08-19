using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using System.Numerics;

namespace nilnul.num._real.approach.convert_._tg.of_._quotient._series
{
	/// <summary>
	/// (-1) ^ n * 2^(2n+2) * (2^ (2n+2) -1) / (2n+2)! * B[2n+2] * x^(2n+1)
	/// </summary>
	public class TermsGivenByUnreliableSrc
		: nilnul.num.quotient.SliderI	//2
	{

		private Q1 _2pow_2nPlus2;
		private BigInteger _2nPlus2;
		private Q1 _2nPlus2Factorial;
		private nilnul.num.quotient.slider_.bernoulli_.Recur bernoulli = new quotient.slider_.bernoulli_.Recur();
		private Q1 _term_withNoSign;
		private Q1 _xPow_2nPlus1;
		private readonly Q1 _xSquare;
		private bool sign;

		public TermsGivenByUnreliableSrc(Q1 x)
		{
			_2pow_2nPlus2 = 4;

			_2nPlus2 = 2;
			_2nPlus2Factorial = 2;

			_xPow_2nPlus1 = x;
			sign = true;
			bernoulli.moveNext();
			bernoulli.moveNext();

			_term_withNoSign =_2pow_2nPlus2 * (_2pow_2nPlus2 - 1) / _2nPlus2Factorial * bernoulli.current * _xPow_2nPlus1;

			_xSquare = nilnul.num.quotient.op_._SquareX.Square(x);
		}

		/// <summary>
		/// From (Hua-feng Ge, new sharp bounds for the Bernoulli Numbers and Refinement of Becker-Stack Inequalities. Hindawi Publishing. Vol2012), the bounds for |Bernoulli[2n]| is 
		/// 
		/// (
		///		2^(2n)! / (2Pi)^(2n) /( 1- 2^(-2n) )
		///		,
		///		2^(2n)! / (2Pi)^(2n) /( 1- 2^(1-2n) )
		/// )
		/// 
		/// for B[2n+2],
		/// (
		///		2*(2n+2)! / (2Pi)^(2n+2) /( 1- 2^(-2n-2) )
		///		,
		///		2*(2n+2)! / (2Pi)^(2n+2) /( 1- 2^(1-2n-2) )
		/// )
		/// Then we compute the coefficient of the tan(x) term.Note: the n-th term is taking B[2n+2], not B[2n]. The upper boudn and lowe bound are:
		/// (
		///		the upper bound * ( 2^(2n+2) -2 ) / ( 2^(2n+2) -1)
		///		=2/Pi * (2^(2n+2) -2 ) / ( 2^(2n+1) -1 )
		///		=4/Pi * ( x/(pi/2) ) ^(2n+1)
		///		,
		///		2/Pi *( 2^(2n+2) -1 ) / ( 2^(2n+1) -1 ) * ( x/(pi/2) )^(2n+1)
		///		=2/Pi 
		///			*
		///			(2 + 
		///				1/ ( 2^(2n+1) -1 )  
		///			)
		///			* 
		///			( x/(pi/2) ) ^(2n+1)
		/// )
		/// Note: that for the upper bound, 1/ ( 2^(2n+1) -1 ) is a decreasing function. So this is also the upper bound of the coefficient for all remaining terms.
		/// Now we can take the remaider of the series as a geometic series and estimate the error.
		/// We can computer the series of lowerbound remaiders, and get the sum. since Pi is involved, we can use a quotent to replace it to relax the lowerbound.
		///		2* 2/pi * (2x/pi)^(2n+1) / (1- 2x/pi)
		/// We can also get the series of the upperbound, and since Pi is invovled we can use a quotient to replace the Pi to relax the upperbound.
		///		(2+ 1/ (2^(2n+1)-1) ) 
		///		* 
		///		2/pi *   (2x/pi)^(2n+1) / (1- 2x/pi)
		/// The span between the two is:
		///		1/ (2^(2n+1)-1)
		///		* 
		///		2/pi *   (2x/pi)^(2n+1) / (1- 2x/pi)
		///	Thus we can get the error estimation. (we need to find a quotient q greater than 2x/pi but less than one) 
		/// /// 
		/// </summary>
		public Simplify.Ed1 current
		{
			get
			{
				return sign? _term_withNoSign: -_term_withNoSign;
			}
		}
		//private Q1 x;



		public void moveNext()
		{
			
			_2pow_2nPlus2 *= 4;
			_2nPlus2 ++;

			_2nPlus2Factorial*= _2nPlus2; //_2nPlus2;
			_2nPlus2++;
			_2nPlus2Factorial *= _2nPlus2;

			bernoulli.moveNext();	bernoulli.moveNext();

			_xPow_2nPlus1 *= _xSquare;

			_term_withNoSign= _2pow_2nPlus2 * (_2pow_2nPlus2 - 1) / _2nPlus2Factorial * bernoulli.current *_xPow_2nPlus1;
			sign = !sign;


		}
	}
}
