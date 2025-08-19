using nilnul.obj._stream_._next;
using nilnul.obj.stream_._slider._skid_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_.positive.factorial
{
	/// <summary>
	/// 
	/// </summary>
	public class Inverse
		: nilnul.obj.box_.OfNew<Factorial>
		,
		nilnul.num.quotient_.denomNonnil.stream_.SliderI
	{
		/// <summary>
		/// initially: 1.
		/// </summary>
		public  BigInteger indexAhead => boxed.toBeCumulated;	// to be multiplied. initially, this is 1 from 1*2*3*...

		

		public BigInteger denominator=> boxed.current;	// initially, this is 1 ,which is prod();.

		public Q4 current => nilnul.num.quotient_.DenomNonnil.Inverse(
			boxed.current
		);

		public void moveNext()
		{
			boxed.moveNext();
		}

		public Q4 next()
		{
			return nilnul.obj.stream_._slider.SkidX.Next(this);

		}
	}
}
