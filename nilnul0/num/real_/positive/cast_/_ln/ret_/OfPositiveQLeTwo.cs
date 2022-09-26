using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num.Quotient1;

using nilnul.num.quotient;
using q = nilnul.num.quotient;
using nilnul.num;

using R = nilnul.num.Real;
using nilnul.num._real_;
using nilnul.num.quotient_;

namespace nilnul.num.real.op_.unary_._ln.ret_._ofPositiveQLeTwo
{

	public class Series

			: nilnul.num.quotient.stream.SeriesI1 //.SeriesI
			, nilnul.num.quotient.StreamI6


	{


		private Q1 _arg_powed_nPlus__Inverse;

		public Q1 arg_powed_nPlus__Inverse
		{
			get { return _arg_powed_nPlus__Inverse; }
			set { _arg_powed_nPlus__Inverse = value; }
		}
		private Q1 _accumulated = 0;
		public Q1 accumulated
		{
			get
			{
				return _accumulated;
				//throw new NotImplementedException();
			}
		}
		private Q1 _accumulatedNext;
		public Q1 accumulatedNext
		{
			get
			{
				return _accumulatedNext;
				//throw new NotImplementedException();
			}
		}

		private Q1 _nextAugend;
		public Q1 nextAugend
		{
			get
			{
				return _nextAugend;

				//throw new NotImplementedException();
			}
		}

		private q.StreamI6 _streamB4Series;

		public q.StreamI6 streamB4Series
		{
			get { return _streamB4Series; }
			//set { _streamB4Series = value; }
		}


		private Q1 _arg;

		public Q1 arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public Q1 current => throw new NotImplementedException();

		public Series(Q1 arg)
		{

			_streamB4Series = nilnul.num.quotient.stream.aggregate_._ProductX.Aggregate(
				 nilnul.num.quotient.stream_.Integer.OvAltSign()
				,
				new nilnul.num.quotient.stream_.Inverse1()
				,
				new nilnul.num.quotient.stream_.PoweredSinceOne1(arg - 1)


			);

			_arg = arg;

			_arg_powed_nPlus__Inverse = 1 / arg;


			_nextAugend = _streamB4Series.next();

			_accumulatedNext += _nextAugend;

		}

		public Series(QuotientI en):this(new Q1(en))
		{
		}

		public Q1 next()
		{
			_accumulated += _accumulatedNext;

			_nextAugend = _streamB4Series.next();

			_accumulatedNext += _nextAugend;



			_arg_powed_nPlus__Inverse /= _arg;


			return _accumulated;

			//throw new NotImplementedException();
		}

		public void moveNext()
		{
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// This is very slow for x approaching 2.
	/// </summary>
	/// 


}

namespace nilnul.num._real.approach.op_._ln.ret_
{

	public class OfPositiveQLeTwo
		:
		nilnul._call.ArgA<nilnul.num.quotient.be_.positive_.leTwo.vow.En>
		,

		nilnul.num.RealI
	{






		private _ofPositiveQLeTwo.Series _series;

		public _ofPositiveQLeTwo.Series series
		{
			get { return _series; }
			set { _series = value; }
		}





		public OfPositiveQLeTwo(nilnul.num.quotient.be_.positive_.leTwo.vow.En arg) : base(arg)

		{
			_series = new _ofPositiveQLeTwo.Series(arg.en);


		}




		public 		q.Bound bound => 
			q.Bound.CreateClose_orderIfNecessary(
				_series.accumulatedNext, _series.accumulated + _series.nextAugend * _series.arg_powed_nPlus__Inverse
			);
				

		public void squeeze(quotient_.Positive1 diameter)
		{
			while (bound.notSpanLessThan(diameter))
			{
				for (int i = 0; i < 10000; i++)
				{
					_series.next();

				}

			}


		}
	}
}