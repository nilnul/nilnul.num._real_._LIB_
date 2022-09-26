using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.real.to_
{
	/// <summary>
	/// get one integer that is the nearest.
	/// </summary>
	public class Round
	{
		static public BigInteger Eval(RealI approach, nilnul.num.quotient_.Positive1 span) {
			approach.squeeze(
				span
			);

			return nilnul.num.quotient._RoundX.Round( approach.current.midPoint);
		}

		static public BigInteger Eval(RealI approach) {
			approach.Clamp(
				new nilnul.num.Quotient1(1,2)	//lt one
			);

			return nilnul.num.quotient._RoundX.Round( approach.current.midPoint);
		}

	}
}
