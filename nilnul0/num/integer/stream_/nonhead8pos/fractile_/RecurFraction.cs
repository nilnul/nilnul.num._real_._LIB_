using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;

namespace nilnul.num.real.recurFraction
{
	public partial class RecurFraction
		
	{

		private nilnul.num.quotient._stream.ContinuedFraction _continuedFraction;

		public nilnul.num.quotient._stream.ContinuedFraction continuedFraction
		{
			get { return _continuedFraction; }
			set { _continuedFraction = value; }
		}

		private Tail _tail;

		public Tail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		public RecurFraction(BigInteger floor, Tail tail)
		{

			_floor = floor;
			_tail = tail;
		}
		public RecurFraction(BigInteger floor,nilnul.num._positive.StreamI stream)
			:this(floor, new Tail(stream))
		{

			
		}
		public RecurFraction(nilnul.num._positive.StreamI stream)
		{

			_floor = 0;
			_tail = new Tail(stream);
		}
		public Nonempty.Asserted interval
		{
			get
			{
				return _tail.interval+_floor;

				throw new NotImplementedException();
			}
		}

		public void converge(Positive.Asserted diameter)
		{
			_tail.converge(diameter);
			return;

			throw new NotImplementedException();
		}

		RecurFraction Create(nilnul.num._positive.StreamI stream) {

			return new RecurFraction(
				stream
				
			);

		}
		RecurFraction Create(BigInteger floor, nilnul.num._positive.StreamI stream) {

			return new RecurFraction(
				floor,
				stream
				
			);

		}
		RecurFraction CreateGoldRatio() {
			return Create(
				1,

				new nilnul.num._positive.stream.Repeater(1)
				
			);
		}
		RecurFraction CreateMetallicRatio(BigInteger n) {
			return Create(
				n,

				new nilnul.num._positive.stream.Repeater(1)
				
			);
		}

		RecurFraction CreateSilverRatio() {
			return Create(
				2,

				new nilnul.num._positive.stream.Repeater(2)
				
			);
		}
	}
}
