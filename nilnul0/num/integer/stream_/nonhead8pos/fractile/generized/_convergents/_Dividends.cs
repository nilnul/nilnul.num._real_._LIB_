using System.Numerics;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.generalized._convergents
{
	public class _Dividends

	{
		BigInteger _prev = 1;

		public ref BigInteger prev { get { return ref _prev; } }


		/// <summary>
		/// adder can be zero if the integer part is disregarded;
		/// </summary>
		BigInteger _current ;

		public ref BigInteger current { get { return ref _current; } }

		public _Dividends(BigInteger adder0)
		{
			_current = adder0;
		}

		/// <summary>
		/// If adder[0] is 0, then adder[1] is not involed in the calculation.
		/// </summary>
		/// <param name="adder"></param>
		/// <param name="numer"></param>
		public void moveNext(BigInteger adder,BigInteger numer)
		{
			_current = _prev*numer + (_prev = _current) * adder;
		}


		public BigInteger seek(BigInteger adder,BigInteger numer)
		{
			moveNext(adder,numer);
			return _current;
		}
	}


}
