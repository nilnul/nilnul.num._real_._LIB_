using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.series_._arcsin.terms_
{
	/// <summary>
	///
	/// 
	/// which converges for −1≤x≤1.
	/// 
	/// </summary>
	public class OfQuotient
		:
		//nilnul.obj.Box1<nilnul.num.RealI>,

		nilnul.num.quotient_.denomNonnil.stream_.SliderA
	{


		_terms.Coefs _coefs = new _terms.Coefs();
		private quotient_.denomNonnil. stream_.slider_.geometric_.Ponent8odd _polyOdd;

		/// <summary>
		/// x,x^3,x^5,
		/// </summary>

		public quotient_.denomNonnil.stream_.slider_.geometric_.Ponent8odd polyOdd
		{
			get { return _polyOdd; }
			//set { _polyOdd = value; }
		}


		

		public OfQuotient(num.quotient_.DenomNonnil val) 
		{
			_polyOdd = new quotient_.denomNonnil.stream_.slider_.geometric_.Ponent8odd(val);
		}

		public nilnul.num.quotient_.DenomNonnil coef { get {
				return _coefs.current;
			} }
		public override num.quotient_.DenomNonnil current => _coefs.current * _polyOdd.current;

		public override void moveNext()
		{
			
			_coefs.moveNext();
			_polyOdd.moveNext();
		}

		//public RealI next()
		//{
		//	return nilnul.obj.stream_._slider.CursorX.Next(this);
		//}
	}
}
