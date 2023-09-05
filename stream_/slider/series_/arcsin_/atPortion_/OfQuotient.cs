using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil.stream_.slider;
using nilnul.obj.stream_._slider._cursor_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.series_.arcsin_.atPortion_
{
	/// <summary>
	/// for any quotient in (0,1), which is <see cref="num.quotient.bound_.boolish_.IPortion"/>
	/// </summary>

	public class OfQuotient
		:
		nilnul.obj.Box_ofIn<
		nilnul.num.quotient_.denomNonnil.stream_.slider.Series
		>
		
		,
		nilnul.num.RealI1
	{
		 OfQuotient(in Series val) : base(val)
		{
		}

		 OfQuotient(Series x) : base(x)
		{
		}

		 OfQuotient(_arcsin.terms_.OfQuotient val) : this(
			new Series( val) 
		)
		{
			

		}
		public OfQuotient(num.quotient_.DenomNonnil val) : this(
			 new _arcsin.terms_.OfQuotient(val) 
		)
		{
			this.arg = val;
			_xSq = nilnul.num.quotient.of_.unary_._SquareX.Square(this.arg);
			_xSqComple = 1 - _xSq;

			_computeBound();

		}




		public num.quotient_.DenomNonnil arg { get; private set; }

		private num.quotient_.DenomNonnil _xSq;

		private num.quotient_.DenomNonnil _xSqComple;


		private (DenomNonnil, DenomNonnil) _bound;

		void _computeBound()
		{

			var variation = this.boxed.toBeCumulated /_xSqComple;

			_bound = (this.boxed.current,this.boxed.current +variation);

		}


		public  (DenomNonnil, DenomNonnil) current { 
			get
			{
				return _bound;
			

			}
		}


		public void clamp(quotient_.denomNonnil_.Positive diameter)
		{
			/// we need   futureNextAugment / (1-x^2) le the given;
			///	that is: futureNextAugment le diameter* (1-x^2)
			///	nextAugment * xSq^n le diameter* (1-x^2)
			///	xSq^n le diameter(1-x^2)/nextAugment
			///	n ge lg(xSq,   diameter(1-x^2)/nextAugment )
			var n = nilnul.num.quotient_.positive_.nonone.duo_.positive._LgX._Lg_0positiveNonone_1positive(
				_xSq
				,
				 _xSqComple *diameter.eeByRef  / this.boxed.toBeCumulated
			);

			while (n.Item2-->0)
			{
				moveNext();
			}






			_computeBound();

		}

		public void moveNext()
		{
			boxed.moveNext();
		}
	}
}
