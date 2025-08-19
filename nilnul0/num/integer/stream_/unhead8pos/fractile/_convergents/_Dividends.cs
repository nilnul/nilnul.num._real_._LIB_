using System.Numerics;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile._convergents
{
	/// <summary>
	/// initially the current is at index: -1
	/// </summary>
	public class _Dividends

	{
		BigInteger _prev = 0;

		public ref BigInteger prev { get { return ref _prev; } }

		BigInteger _current = 1;

		public ref BigInteger current { get { return ref _current; } }
	

		public void moveNext(BigInteger adder)
		{
			_current = _prev + (_prev = _current) * adder;
		}

		/// <summary>
		/// next has to be called to get the convergent0
		/// </summary>
		/// <param name="adder"></param>
		/// <returns></returns>
		public BigInteger next(BigInteger adder)
		{
			return _current = _prev + (_prev = _current) * adder;
		}
	}


}
