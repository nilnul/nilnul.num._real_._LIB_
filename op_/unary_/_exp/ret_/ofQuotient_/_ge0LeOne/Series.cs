using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;

namespace nilnul.num._real.approach.op_._exp.ret_.ofQ_._ge0LeOne
{
	public class Series
		: nilnul.num.quotient.SeriesI
		,
		q.StreamI3
	{
		private Simplify.Ed1 _accumulated = 0;

		public Simplify.Ed1 accumulated
		{
			get
			{
				return _accumulated;

				//throw new NotImplementedException();
			}
		}


		private Q1 _nextAugend;

		public Simplify.Ed1 nextAugend
		{
			get
			{
				return _nextAugend;
			//	throw new NotImplementedException();
			}
		}

	

		private q.StreamI3 _stream;



		public Series(q.be_.GeZeroLeOne.En index)
		{
			
			_stream = nilnul.num.quotient.stream.duo.op.Multi.Singleton.eval(
				new q.stream_.FactorialInversed()
				,
				new q.stream_.Powered(index.val)	
			);
		}


		public Q1 next()
		{

			_nextAugend = _stream.next();

			_accumulated += _nextAugend;
			return _accumulated;


			//throw new NotImplementedException();
		}
	}
}
