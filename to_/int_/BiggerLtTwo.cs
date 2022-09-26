using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.real.to_.int_
{
	/// <summary>
	/// get one integer that is the nearest.
	/// </summary>
	static public class _GeDistanceLtTwoX
	{
		static public BigInteger NonSmallerLtTwo(RealI r, nilnul.num.quotient_.Positive1 span) {

			r.squeeze(
				span
			);
			return nilnul.num.quotient._CeilX.Ceil( r.current.upper.mark);
		}

		public  static BigInteger NonSmallerLtTwo(RealI x, Quotient1 quotient1)
		{
			return NonSmallerLtTwo(x, new num.quotient_.Positive1(quotient1) );
		}
		static public BigInteger NonSmallerLtTwo(RealI approach) {
			return NonSmallerLtTwo(approach, nilnul.num.Quotient1.CreateHalf());
		}

	}
}
