using nilnul.num.quotient_;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.convergent
{
	static public class _SeqX
	{

		/// <summary>
		/// the value of the fractile, which is the end of the searies;
		/// </summary>
		/// <param name="adders"></param>
		/// <returns></returns>
		static public IEnumerable<DenomNonnil> _Seq_0fractile8stream(IEnumerable<BigInteger> adders)
		{

			//var addersCount = adders.Count();

			//if (addersCount == 1)
			//{
			//	return new DenomNonnil(adders.First());
			//}

			var uppers = new fractile.convergent._seq._Dividends(adders).GetEnumerator();

			var lowers = new fractile.convergent._seq._Divisors(adders).GetEnumerator();

			while (true)
			{
				lowers.MoveNext();
				uppers.MoveNext();
				yield return new DenomNonnil(
					uppers.Current
					,
					lowers.Current
				);
			}
		}

		public static IEnumerable<DenomNonnil> _Seq_0fractile8stream(IEnumerable<int> x)
		{
			return _Seq_0fractile8stream(
				x.Select(t => (BigInteger)t)
			);
		}
	}
}
