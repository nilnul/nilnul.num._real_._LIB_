using nilnul.num.quotient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;

namespace nilnul.num.real.recurFraction
{
	public class Tail
		//:RealI
	{

		private nilnul.num.quotient._stream._continuedFraction.Tail _tail;

		public nilnul.num.quotient._stream._continuedFraction.Tail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}


		public Tail(num._positive.StreamI stream)
		{
			_tail = new quotient._stream._continuedFraction.Tail(stream);

		}
		private nilnul.num.quotient.Q _quotient;


		private nilnul.num._positive.StreamI _positiveNumStream;

		public Nonempty.Asserted interval
		{
			get
			{
				return Nonempty.Asserted.CreateOpen_orderIfNeed((num.rational.Rational_InheritFraction2)_lower, (num.rational.Rational_InheritFraction2)_upper);

				throw new NotImplementedException();
			}
		}

		private nilnul.num.quotient.Q _lower;

		public nilnul.num.quotient.Q lower
		{
			get { return _lower; }
			set { _lower = value; }
		}

		private nilnul.num.quotient.Q _upper;

		public nilnul.num.quotient.Q upper
		{
			get { return _upper; }
			set { _upper = value; }
		}


		public nilnul.num._positive.StreamI positiveNumStream
		{
			get { return _positiveNumStream; }
			set { _positiveNumStream = value; }
		}

		public nilnul.num.quotient.Q ComputeTill(BigInteger n)
		{
			return quotient.form.continuedFraction.ProperContinuedFraction._ToFraction(nilnul.num.type.stream.ExtensionMethods.AsStr(_positiveNumStream, n));
		}

		public void converge(Positive.Asserted diameter)
		{
			var t = _tail.next();
			var t1 = _tail.next();
			while (nilnul.num.quotient.Q.Abs( t1-t)> ((nilnul.num.quotient.Q)(diameter.val)))
			{
				t = t1;
				t1 =_tail.next();
			}
			_lower = t;
			_upper = t1;
			return;


			throw new NotImplementedException();
		}
	}
}
