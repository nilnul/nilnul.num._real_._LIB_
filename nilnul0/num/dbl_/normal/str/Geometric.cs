using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.doubl.normal.str
{
	
	public class Geometric_givenHead 
	{

		private doubl.be.Normal.Asserted _head;

		public doubl.be.Normal.Asserted head
		{
			get { return _head; }
			set { _head = value; }
		}

		private doubl.be.Normal.Asserted _rate;

		public doubl.be.Normal.Asserted rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		private nilnul.num.bigint.be.Natural.Asserted _count;

		public nilnul.num.bigint.be.Natural.Asserted  count
		{
			get { return _count; }
			set { _count = value; }
		}






		public Geometric_givenHead(doubl.be.Normal.Asserted head, doubl.be.Normal.Asserted rate, nilnul.num.bigint.be.Natural.Asserted count)
		{
			_head = head;
			_rate = rate;

			_count = count;
		}

		public Geometric_givenHead(doubl.be.Normal.Asserted head, doubl.be.Normal.Asserted rate, int count)
			:this(head,rate,new bigint.be.Natural.Asserted(count))
		{
			
		}

		public Geometric_givenHead(double head, double rate, int count)
			:this(new be.Normal.Asserted( head), new be.Normal.Asserted( rate),new bigint.be.Natural.Asserted(count))
		{
			
		}

		public Geometric_givenHead(double head, double rate, nilnul.num.bigint.be.Natural.Asserted  count)
			:this(new be.Normal.Asserted( head), new be.Normal.Asserted( rate),(count))
		{
			
		}


		public IEnumerator<doubl.be.Normal.Asserted> GetEnumerator()
		{
			var ratio = 1.0;
			for (BigInteger i = 0; i < count; i++)
			{
				yield return new be.Normal.Asserted( _head.val * ratio);
				ratio *= _rate.val;
			}
			//throw new NotImplementedException();
		}

		

		

		static public Geometric_givenHead Create_headIsOne( double d, int count) {

			return new Geometric_givenHead(
				1.0//
				,
				d
				,
				new bigint.be.Natural.Asserted(count)

			);

		}

		static public Geometric_givenHead CreateHalfHalf(int count) {
			return new Geometric_givenHead(.5, .5,
				
				count
				
				);
		}

		public double sum() {
			return _head.val * geometric.HeadOne._Sum(_rate.val, _count.val);

		}

		static public double Sum(double head, double rate, int count) {
			return head * geometric.HeadOne._Sum(rate, count);
		}

		static public double Sum(double head, double rate, nilnul.num.bigint.be.Natural.Asserted count) {
			return head * geometric.HeadOne._Sum(rate, count);
		}







	}

	
}
