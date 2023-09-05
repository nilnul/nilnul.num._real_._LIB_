using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;

namespace nilnul.num._real.approach_.tau_._one__Plus__OddSince3_PositiveSquare___UnderEight
{
	/// <summary>
	/// converges linearly to π, adding at least three decimals digits of precision per four terms, a pace slightly faster than the arcsine formula for π:
	/// </summary>
	public class OddSince3_PositiveSquare
		: nilnul.num.quotient.slider_.ProperGeneralContinuedFrac
	{
		public OddSince3_PositiveSquare() : base(
			nilnul.num.quotient.slider.convert_.Skip.SkipOne.eval(
				new nilnul.num.quotient.slider_.fro_.Natural(
					new nilnul.num.slider_.Odd()
				)
			)
			,
			new nilnul.num.quotient.slider_.fro_.Natural(
				new nilnul.num.slider_.PositiveSquared()
			)
		)
		{


		}


	}
}
