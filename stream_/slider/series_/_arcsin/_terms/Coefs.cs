using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.series_._arcsin._terms
{
	/// <summary>
	///
	/// 
	/// 
	/// </summary>
	public class Coefs
		:
		//nilnul.obj.Box1<nilnul.num.RealI>,

		nilnul.num.quotient_.denomNonnil.stream_.SliderA
	{

	


		private nilnul.num.integer.stream_.slider_.eachy_.nonneg_.Odd _odd=new integer.stream_.slider_.eachy_.nonneg_.Odd();

		//nilnul.num.integer.stream_.slider_.

		/// <summary>
		/// 1,3,5,...
		/// </summary>
		public nilnul.num.integer.stream_.slider_.eachy_.nonneg_.Odd odd
		{
			get { return _odd; }
			//set { _odd= value; }
		}


		private nilnul.num.integer.stream_.slider_.eachy_.positive_.refac_.Odd   _oddRefac=new integer.stream_.slider_.eachy_.positive_.refac_.Odd();

		/// <summary>
		/// (-1)!!, 1!!, 3!!
		/// </summary>
		public nilnul.num.integer.stream_.slider_.eachy_.positive_.refac_.Odd oddRefac
		{
			get { return _oddRefac; }
			//set { _oddSinceOneRefact = value; }
		}





		private nilnul.num.integer.stream_.slider_.eachy_.positive_.ReFactorial _refac=new integer.stream_.slider_.eachy_.positive_.ReFactorial();



		public override nilnul.num.quotient_.DenomNonnil current { get {
				return new quotient_.DenomNonnil(
					_oddRefac.current
					,
					 _refac.current * _odd.current 
				); ;
			} }

		public override void moveNext()
		{
			_oddRefac.moveNext();
			_odd.moveNext();
			_refac.moveNext();
		}

		//public RealI next()
		//{
		//	return nilnul.obj.stream_._slider.CursorX.Next(this);
		//}
	}
}
