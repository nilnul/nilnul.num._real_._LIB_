using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;
using q = nilnul.num.quotient;

namespace nilnul.num.real.op_.unary_._exp.ret_.ofQuotient_._ofPositive
{
	public class Series
		: nilnul.num.quotient.stream.buffered.Series //.stream.holdable.series.Lag
		
	{


		public Series(Q1 index)
			:base(
				 nilnul.num.quotient.stream.combine_.Multi.Singleton.combine(
					new q.stream_.slider_.factorial.Inverse()
					,
					new q.slider_.geometric_.std.Stream(index)	
				)
				 ,
				 1
			)
				
		{
			
			
		}


		

	}

	//public class Memory
	//	:nilnul.num.quotient.stream.Holdable
	//{


	//	private Lag _series;

	//	public Lag series
	//	{
	//		get { return _series; }
	//		set { _series = value; }
	//	}


	//	private Q1 _accumulated;
	//	public Q1 accumulated
	//	{
	//		get
	//		{
	//			return _series.accumulated;

	//			throw new NotImplementedException();
	//		}
	//	}

	//	public Q1 _accumulatedNext;


	//	private Q1 _nextAugend;

	//	public Q1 nextAugend
	//	{
	//		get { return _series.nextAugend; }
	//		set { _nextAugend = value; }
	//	}


	//	public Memory(Q1 x)
	//	{
	//		_series = new Lag(x);



	//		_accumulated = _series.accumulated;
	//		_nextAugend = _series.nextAugend;


	//		_series.moveNext();

	//		_accumulatedNext = _series.accumulated;


	//	}

	//	public void moveNext()
	//	{

	//		 _accumulated=_accumulatedNext;
	//		_nextAugend = _series.nextAugend;


	//		_series.moveNext();

	//		_accumulatedNext = _series.accumulated;

			


	//		//throw new NotImplementedException();
	//	}
	//}


}
