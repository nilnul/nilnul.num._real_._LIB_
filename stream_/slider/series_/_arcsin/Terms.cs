using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.series_._arcsin
{
	/// <summary>
	///
	/// 
	/// which converges for −1≤x≤1.
	/// 
	/// </summary>
	public class Terms
		:
		//nilnul.obj.Box1<nilnul.num.RealI>,

		nilnul.num.real.stream_.SliderA
	{


		_terms.Coefs _coefs = new _terms.Coefs();
		private stream_.slider_.geometric_.PolyOdd _polyOdd;

		/// <summary>
		/// x,x^3,x^5,
		/// </summary>

		public stream_.slider_.geometric_.PolyOdd polyOdd
		{
			get { return _polyOdd; }
			//set { _polyOdd = value; }
		}




		public Terms(RealI val) 
		{
			_polyOdd = new slider_.geometric_.PolyOdd(val);
		}

		public nilnul.num.quotient_.DenomNonnil coef { get {
				return _coefs.current;
			} }
		public override RealI current => _coefs.current * _polyOdd.current.ToReal();

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
