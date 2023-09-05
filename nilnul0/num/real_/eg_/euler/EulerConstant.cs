using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using nilnul.num.quotient;
using System.Numerics;
using q = nilnul.num.quotient;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.real._subtypeS._eulerConst
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// http://numbers.computation.free.fr/Constants/Gamma/gamma.html#CITEYoung
	/// R.M. Young, Euler's constant, Math. Gazette 75, (1991), vol. 472, p. 187-190
	/// 
	/// H[n]-Ln[n]-gamma &isin; (1/(2(n+1)),  1/(2n))
	/// 
	/// so gamma=H[n]-Ln(n) - (1/(2(n+1)),  1/(2n))
	/// 
	/// http://math.stackexchange.com/questions/129777/what-is-the-fastest-most-efficient-algorithm-for-estimating-eulers-constant-g
	/// 
	/// </remarks>
	/// 
	[Obsolete("too slow. see _quatic, which is faster.")]
	public class Macys_nSquare : RealI_posConverge2NonEmpty
	{
		//private BigInteger _n=1;
		//	private Q _n_inversed=1;

		//private Q _nPlus1_Inversed=Q.CreateHalf();
		//private Q _lower=Q.CreateHalf();
		//private Q _upper=1;

		//private Q _lower_negPart___lt0;
		//private Q _upper_negPart___lt0;

		private BigInteger _n_plus1 = 2;
		private Q _harmonic = 1;

		//private Q _lower_negPart___gt0=1;

		private Q _upper_negPart___gt0 = 0;
		BigInteger nSquare_plus_n = 2;


		//BigInteger N1_times_N1__plus_N1=6;

		public Nonempty.Asserted interval
		{
			get
			{

				var _upper = _harmonic - _upper_negPart___gt0;

				//var _lower = _upper - Q.Inverse(nSquare_plus_n);

				return q.Interval.CreateOpen(
					_upper - Q.Inverse(nSquare_plus_n)
					,
					_upper
				).toBasedNoEmpty();



				throw new NotImplementedException();
			}
		}

		public void converge(Positive.Asserted diameter)
		{

			_converge(
				q.be.nonNeg.asserted._Sqrt._Eval_ceil(
					Q.Inverse(
						diameter
					)

				)
			);

			//while (interval.notSpanLessThan(diameter))
			//{
			//	_converge( _n_plus1*_n_plus1);
			//}


			return;
			//
			throw new NotImplementedException();
		}

		void _converge(BigInteger nextN__gtCurrent)
		{

			//	var neg2pos = Q.CreateZero();

			for (; _n_plus1 <= nextN__gtCurrent; _n_plus1++)
			{

				_harmonic += Q.Inverse(_n_plus1);

			}

			//_harmonic += neg2pos;




			nSquare_plus_n = _n_plus1;

			_upper_negPart___gt0 = Q.CreateZero();

			for (; nSquare_plus_n < nextN__gtCurrent * nextN__gtCurrent + nextN__gtCurrent; nSquare_plus_n++)
			{
				_upper_negPart___gt0 += Q.Inverse(
					nSquare_plus_n
				);
			}

			//	_upper = _harmonic - _upper_negPart___gt0;

			//_lower = _upper - Q.Inverse(nSquare_plus_n);

			return;
			//
			throw new NotImplementedException();
		}

	}
	public class Macys_quatic : RealI_posConverge2NonEmpty
	{
		//private BigInteger _n=1;
		//	private Q _n_inversed=1;

		//private Q _nPlus1_Inversed=Q.CreateHalf();
		//private Q _lower=Q.CreateHalf();
		//private Q _upper=1;

		//private Q _lower_negPart___lt0;
		//private Q _upper_negPart___lt0;

		private BigInteger _n_plus1 = 2;
		private Q _harmonic = 1;

		//private Q _lower_negPart___gt0=1;

		//	private Q _upper_negPart___gt0 = 0;
		//		BigInteger nSquare_plus_n = 2;
		private Q _upper;
		private Q _lower;


		//BigInteger N1_times_N1__plus_N1=6;

		public Nonempty.Asserted interval
		{
			get
			{



				//var _lower = _upper - Q.Inverse(nSquare_plus_n);

				return q.Interval.CreateOpen(
					_lower
					,
					_upper
				).toBasedNoEmpty();



				throw new NotImplementedException();
			}
		}

		public void converge(Positive.Asserted diameter)
		{

			_converge_mayLe(q.be.nonNeg.asserted._Sqrt._Eval_ceil(
				q.be.nonNeg.asserted._Sqrt._Eval_ceil(
					Q.Inverse(
						(Q)diameter / 36
					)

				)
				)
			);

			//while (interval.notSpanLessThan(diameter))
			//{
			//	_converge( _n_plus1*_n_plus1);
			//}


			return;
			//
			throw new NotImplementedException();
		}
		void _converge_mayLe(BigInteger nextN_)
		{
			if (nextN_ < this._n_plus1)
			{
				return;
			}
			else
			{
				_converge(nextN_);
			}

		}

		void _converge(BigInteger nextN__gtCurrent)
		{

			//	var neg2pos = Q.CreateZero();



			for (; _n_plus1 <= nextN__gtCurrent; _n_plus1++)
			{
				_harmonic += Q.Inverse(_n_plus1);

			}

			//_harmonic += neg2pos;


			var nSquare_plus_n = _n_plus1;

			var _upper_negPart___gt0 = Q.CreateZero();

			for (; nSquare_plus_n < nextN__gtCurrent * nextN__gtCurrent + nextN__gtCurrent; nSquare_plus_n++)
			{
				_upper_negPart___gt0 += Q.Inverse(
					nSquare_plus_n
				);
			}

			_upper_negPart___gt0 += Q.Inverse(
					nSquare_plus_n
			);

			var nSquare_plus_n___times6 = nSquare_plus_n * 6;


			var harmonic_minus_ = _harmonic - _upper_negPart___gt0;


			_upper = harmonic_minus_ + Q.Inverse(nSquare_plus_n___times6);

			_lower = harmonic_minus_ + Q.Inverse(nSquare_plus_n___times6 + 1);

			return;
			//
			throw new NotImplementedException();
		}

	}
	public class Macys_poly12_ : RealI_posConverge2NonEmpty
	{
		//private BigInteger _n=1;
		//	private Q _n_inversed=1;

		//private Q _nPlus1_Inversed=Q.CreateHalf();
		//private Q _lower=Q.CreateHalf();
		//private Q _upper=1;

		//private Q _lower_negPart___lt0;
		//private Q _upper_negPart___lt0;
		private BigInteger _n = 2;

		//private BigInteger _n_plus1 = 3;
		//private BigInteger _n_minus1 = 1;
		private Q _harmonic_lt_n = 1;

		//private Q _lower_negPart___gt0=1;

		//	private Q _upper_negPart___gt0 = 0;
		//		BigInteger nSquare_plus_n = 2;
		private Q _upper;
		private Q _lower;


		//BigInteger N1_times_N1__plus_N1=6;

		public Nonempty.Asserted interval
		{
			get
			{



				//var _lower = _upper - Q.Inverse(nSquare_plus_n);

				return q.Interval.CreateOpen(
					_lower
					,
					_upper
				).toBasedNoEmpty();



				throw new NotImplementedException();
			}
		}

		public Macys_poly12_()
		{

			_setValAftHarmonic();


		}


		public void converge(Positive.Asserted diameter)
		{

			_converge_mayLe(
				q.be.nonNeg.asserted._Root._Eval_ceil(
					Q.Divide(
						Q.Divide(47, 1000),


						(Q)diameter
					)
					, 
					12
				) //+1
				
			);

			//while (interval.notSpanLessThan(diameter))
			//{
			//	_converge( _n_plus1*_n_plus1);
			//}


			return;
			//
			throw new NotImplementedException();
		}
		void _converge_mayLe(BigInteger nextN_)
		{
			if (nextN_ <= this._n)
			{
				return;
			}
			else
			{
				_converge(nextN_);
			}

		}

		void _converge(BigInteger nextN__gtCurrent)
		{
			//	_n_minus1++;


			for (; _n < nextN__gtCurrent; _n++)
			{
				_harmonic_lt_n += Q.Inverse(_n);

			}

			//_harmonic += Q.Inverse(_n_minus1);

			//_n_minus1 += 2;


			//_harmonic += neg2pos;


			var minusPart_index = nextN__gtCurrent + 1;

			var minusPart_abs = Q.CreateZero();

			var _nextN_square = nextN__gtCurrent * nextN__gtCurrent;

			for (; minusPart_index < _nextN_square; minusPart_index++)
			{
				minusPart_abs += Q.Inverse(
					minusPart_index
				);
			}

			minusPart_abs += Q.Inverse(
					3 * _nextN_square
			);

			var nextN_quatic = _nextN_square * _nextN_square;

			minusPart_abs += Q.Inverse(
					10 * nextN_quatic
			);

			var sumUp = _harmonic_lt_n - minusPart_abs;



			var nextN_e6 = _nextN_square * nextN_quatic;

			sumUp += Q.Inverse(
					126 * nextN_e6
			);
			var nextN_e10 = nextN_quatic * nextN_e6;


			sumUp += Q.Inverse(
					66 * nextN_e10
			);





			var nextN_e12_inverse =Q.Inverse( nextN_e6 * nextN_e6);




			_lower= sumUp - Q.Divide(43, 1000) * nextN_e12_inverse;

			_upper = sumUp + Q.Divide(4, 1000) * nextN_e12_inverse;

			return;
			//
			throw new NotImplementedException();
		}
		void _setValAftHarmonic() {
			_setValAftHarmonic(_n);
		}

		void _setValAftHarmonic(BigInteger nextN__gtCurrent)
		{
			

			//_harmonic += Q.Inverse(_n_minus1);

			//_n_minus1 += 2;


			//_harmonic += neg2pos;


			var minusPart_index = nextN__gtCurrent + 1;

			var minusPart_abs = Q.CreateZero();

			var _nextN_square = nextN__gtCurrent * nextN__gtCurrent;

			for (; minusPart_index < _nextN_square; minusPart_index++)
			{
				minusPart_abs += Q.Inverse(
					minusPart_index
				);
			}

			minusPart_abs += Q.Inverse(
					3 * _nextN_square
			);

			var nextN_quatic = _nextN_square * _nextN_square;

			minusPart_abs += Q.Inverse(
					10 * nextN_quatic
			);

			var sumUp = _harmonic_lt_n - minusPart_abs;



			var nextN_e6 = _nextN_square * nextN_quatic;

			sumUp += Q.Inverse(
					126 * nextN_e6
			);
			var nextN_e10 = nextN_quatic * nextN_e6;


			sumUp += Q.Inverse(
					66 * nextN_e10
			);



			var nextN_e12_inverse =Q.Inverse( nextN_e6 * nextN_e6);




			_lower= sumUp - Q.Divide(43, 1000) * nextN_e12_inverse;

			_upper = sumUp + Q.Divide(4, 1000) * nextN_e12_inverse;

			return;
			//
			throw new NotImplementedException();
		}

	}


	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// http://numbers.computation.free.fr/Constants/Gamma/gamma.html#CITEYoung
	/// R.M. Young, Euler's constant, Math. Gazette 75, (1991), vol. 472, p. 187-190
	/// 
	/// H[n]-Ln[n]-gamma &isin; (1/(2(n+1)),  1/(2n))
	/// 
	/// so gamma=H[n]-Ln(n) - (1/(2(n+1)),  1/(2n))
	/// 
	/// </remarks>
	public class EulerConstant : RealI_posConverge2NonEmpty
	{
		static public string DecStr= "0.57721566490153286060651209008240243104215933593992";

		static public double Approximate = 0.57721566490153286060651209008240243104215933593992;
		public quotient.Q harmonic = 1;

		public RealI_posConverge2NonEmpty lnN = real.Quotient_posConverge2Bounded.NewZero();


		private BigInteger _n;
		private BigInteger _n_plus_1;

		private BigInteger _2_times__nPlus1;
		private _real.Quotient_posConverge2Bounded _H_n;

		private RealI_posConverge2NonEmpty _H_n__subtract__ln_n;

		public EulerConstant()
		{
			_n = 1;
			_n_plus_1 = 2;
			_2_times__nPlus1 = 2 * _n_plus_1;

			_H_n = 1;

			_H_n__subtract__ln_n = op.Subtract3.Eval(
				_H_n,
				op.Ln.Eval(_n)
			);


		}

		public Interval interval_quotient
		{
			get
			{
				return quotient.interval.op.Minus.Eval(

					new Interval(
					_H_n__subtract__ln_n.interval.val.lower.eq,
					_H_n__subtract__ln_n.interval.val.lower.pinpoint,

					_H_n__subtract__ln_n.interval.val.upper.eq,
					_H_n__subtract__ln_n.interval.val.upper.pinpoint
					)

					,

					new quotient.Interval(
						false
						,
						nilnul.num.quotient.Q.Inverse(2 * _n_plus_1)
						,
						false
						,
						Q.Inverse(2 * _n)
					)
					)
					;


				throw new NotImplementedException();
			}
		}

		public Nonempty.Asserted interval
		{
			get
			{
				return
					interval_quotient.toBasedNoEmpty();


				throw new NotImplementedException();
			}
		}

		public void converge(Positive.Asserted diameter)
		{

			while (interval.notSpanLessThan(diameter))
			{

				_n = _n_plus_1;
				_n_plus_1++;

				_2_times__nPlus1 += 2;

				_H_n += Q.Inverse(_n);

				_H_n__subtract__ln_n = op.Subtract3.Eval(
					_H_n,
					op.Ln.Eval(_n)
				);

				_H_n__subtract__ln_n.converge(
					new Positive.Asserted(
					Q.Inverse(2 * _n_plus_1))

				);




			}
			return;

			throw new NotImplementedException();
		}
	}
}
