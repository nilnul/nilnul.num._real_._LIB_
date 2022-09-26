using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.series_._arcsin
{
	/// <summary>
	/// which converges for −1≤x≤1.
	/// </summary>
	public class Term
		:
		//nilnul.obj.Box1<nilnul.num.RealI>,

		nilnul.num.real.stream_.SliderA
	{

		private stream_.slider_.geometric_.PolyOdd _polyOdd;

		public stream_.slider_.geometric_.PolyOdd polyOdd
		{
			get { return _polyOdd; }
			//set { _polyOdd = value; }
		}

		//private nilnul.num.quotient.stream_.slider_.odd.Inversed _oddInversed;

		//public nilnul.num.quotient.stream_.slider_.odd.Inversed oddInversed
		//{
		//	get { return _oddInversed; }
		//	set { _oddInversed = value; }
		//}

		private nilnul.num.stream_.slider_.Odd1 _odd=new num.stream_.slider_.Odd1();

		public nilnul.num.stream_.slider_.Odd1 odd
		{
			get { return _odd; }
			//set { _odd= value; }
		}



		private nilnul.num.stream_.slider_.even.map_.ReFact _evenRefact=new num.stream_.slider_.even.map_.ReFact();

		public nilnul.num.stream_.slider_.even.map_.ReFact evenRefact
		{
			get { return _evenRefact; }
			//set { _evenRefact = value; }
		}


		private nilnul.num.integer.stream_.slider_.arithmetic_.twin_.sinceMinusOne.ReFactFroOne  _oddSinceOneRefact=new integer.stream_.slider_.arithmetic_.twin_.sinceMinusOne.ReFactFroOne();

		public nilnul.num.integer.stream_.slider_.arithmetic_.twin_.sinceMinusOne.ReFactFroOne oddSinceOneRefact
		{
			get { return _oddSinceOneRefact; }
			//set { _oddSinceOneRefact = value; }
		}



		public Term(RealI val) 
		{
			_polyOdd = new slider_.geometric_.PolyOdd(val);

		}

		public override RealI current => _oddSinceOneRefact.current.QDiv(_evenRefact.current*_odd.current ) * _polyOdd.current.ToReal();

		public override void moveNext()
		{
			_oddSinceOneRefact.moveNext();
			_evenRefact.moveNext();
			_odd.moveNext();
			_polyOdd.moveNext();
		}

		//public RealI next()
		//{
		//	return nilnul.obj.stream_._slider.CursorX.Next(this);
		//}
	}
}
