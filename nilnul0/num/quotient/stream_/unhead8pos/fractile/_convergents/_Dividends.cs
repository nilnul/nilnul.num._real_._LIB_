using System.Numerics;

namespace nilnul.num.quotient.stream_.nonhead8pos.fractile._convergents
{
	/// <summary>
	/// initially the current is at index: -1
	/// </summary>
	public class _Dividends

	{
		num.quotient_.DenomNonnil _prev = 0;

		public ref num.quotient_.DenomNonnil prev { get { return ref _prev; } }

		num.quotient_.DenomNonnil _current = 1;

		public ref num.quotient_.DenomNonnil current { get { return ref _current; } }
	

		public void moveNext(num.quotient_.DenomNonnil adder)
		{
			_current = _prev + (_prev = _current) * adder;
		}

		/// <summary>
		/// next has to be called to get the convergent0
		/// </summary>
		/// <param name="adder"></param>
		/// <returns></returns>
		public num.quotient_.DenomNonnil next(num.quotient_.DenomNonnil adder)
		{
			return _current = _prev + (_prev = _current) * adder;
		}
	}


}
