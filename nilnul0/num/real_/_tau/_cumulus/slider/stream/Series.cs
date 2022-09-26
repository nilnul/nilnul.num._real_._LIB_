using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.num._real.approach_._tau._series.slider;

namespace nilnul.num._real.approach_.tau_._a.slider.stream
{
	public class Series
		:
		//nilnul.num.quotient.series.FroStream
	//	,
		nilnul.num.quotient.stream.SeriesI

	{
		private slider.Stream _stream;

		//public slider.Stream stream
		//{
		//	get { return _stream; }
		//	//set { _stream = value; }
		//}

		public Q1 coefficientComing { get {
				return _stream.coefficientComing;
			} }
		private nilnul.num.quotient.series.FroStream _series;

		public Series()
		{
			_stream = new _a.slider.Stream();
			_series = new nilnul.num.quotient.series.FroStream(_stream);
		}

		public Q1 accumulated
		{
			get
			{
				return _series.accumulated;
				//throw new NotImplementedException();
			}
		}


		public Q1 current => _series.accumulated;

		public void moveNext()
		{
			_series.moveNext();
			//throw new NotImplementedException();
		}
	}
}
