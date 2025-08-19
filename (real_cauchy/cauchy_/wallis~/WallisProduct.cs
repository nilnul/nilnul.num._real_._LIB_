using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using Q = nilnul.num.quotient.Q;
using System.Numerics;

namespace nilnul.num.real._real.eg
{
	public class WallisProduct : IEnumerable<Q>
	{
		public IEnumerator<Q> GetEnumerator()
		{
			BigInteger num = 0;
			BigInteger den = 1;
			var product = new Q(1);

			while (true)
			{
				yield return product*= new Q(num+=2, den);
				yield return product *= new Q(num, den+=2);
				
			}

			throw new UnexpectedReachException();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
