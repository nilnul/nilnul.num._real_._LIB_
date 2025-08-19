using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using Q = nilnul.num.rational.Rational_InheritFraction2;

using Bound2 = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach_
{
	/// <summary>
	/// Sum[(1/16^k) (4/(8 k + 1) - 2/(8 k + 4) - 1/(8 k + 5) - 1/(8 k + 6)), {k, 0, Infinity}]

	/// </summary>
	/// 

		[Obsolete()]
	public  class Tau:ApproachI1
	{
		#region static

		public const double IntoDoulbe = 2 * Math.PI;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="denominator"></param>
		/// <returns></returns>
		/// <remarks>
		/// 		/// http://functions.wolfram.com/Constants/Pi/06/01/01/0001/
		/// 		or you can use pi/4=arctang(1), but that converges slower.
		/// </remarks>


		
	

		#endregion






		private Q1 _accumulated=0;

		public Q1 accumulated
		{
			get
			{
				return _accumulated;

				throw new NotImplementedException();

			}
		}

		private object _lock = new object();

		//private BigInteger _k = 0;

		//private BigInteger _k_next = 1;
		private BigInteger _8kPlus4_ = 4;
		private BigInteger _8kPlus5_ = 5;
		private BigInteger _8kPlus6_ = 6;
		private BigInteger _8kPlus1_ = 1;

		private BigInteger _16PowK = 1;
		//private BigInteger _16Pow_Knext = 16;

		private Q1 _lastTerm ;

		//private rational.Rational_InheritFraction2 _nextTerm;

		private Q1 _residueUpperBound;

		//static public Q _20Over64_=nilnul.num.rational.Rational_InheritFraction2.Divide2(20,64);

		//static public Q _16over15_ = nilnul.num.rational.Rational_InheritFraction2.Divide2(16, 15);
		//static public Q _3over4_ = nilnul.num.rational.Rational_InheritFraction2.Divide2(3, 4);
		static public Q1 _coefficient = new Q1(128, 3);


		private void _residueUpperBound_ini() {

			_residueUpperBound = _coefficient / 16;
//			_residueUpperBound = _coefficient / _16Pow_Knext;
		}
		private void _lastTerm__set()
		{

			_lastTerm = 2 * nilnul.num.quotient.duo_.dividable.op_._divide.Extensions.Divide(
				new Q1(4, _8kPlus1_)
					- new Q1(2, _8kPlus4_)
					- nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(_8kPlus5_)
					- nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(_8kPlus6_)
				,
				_16PowK
			);

		}

	
	



		public Tau()
		{
			lock (_lock)
			{
				_lastTerm__set();



				_accumulated += _lastTerm;

				_residueUpperBound_ini();

			}
		}


		/// <remarks>
		/// 		http://functions.wolfram.com/Constants/Pi/06/01/01/0012/
		/// 		or you can use pi/4=arctang(1), but that converges slower.
		/// </remarks>

	

		public Bound2 bound
		{
			get {


				return Bound2.CreateOpen(accumulated, accumulated + _residueUpperBound);
				
				throw new NotImplementedException(); 
			
			}
		}

		

		public void clamp(quotient.be_.Positive1.En diameter)
		{

			lock (_lock)
			{
				while ( (bound.notSpanLessThan(diameter)))
				{
			//		_k=_k_next;
		//			_k_next++;

					_16PowK *= 16;
			//		_16PowK = _16Pow_Knext;////////////////

			//		_16Pow_Knext *= 16;/////////////


					_8kPlus1_ += 8;
					_8kPlus4_ += 8;
					_8kPlus5_ += 8;
					_8kPlus6_ += 8;

					_lastTerm__set();

					_accumulated += _lastTerm;

					_residueUpperBound /= 16;
				}



			}
			return;


			throw new NotImplementedException();
		}

		
	}
}
