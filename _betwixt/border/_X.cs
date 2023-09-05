using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.border
{
	static public class CoX
	{
		static public bool Contains(this border.Co duo,  R x)
		{
			return nilnul.num.real.border.comparer_.lower.Re.Singleton.le(duo.lower, x)

				&&
				nilnul.num.real.border.comparer_.upper.Decider.Singleton.ge(duo.upper, x);

		}

		static public R Diameter(this border.Co duo)
		{
			return
				nilnul.num.real.op_.binary_.Minus.Singleton.op(
				duo.upper.mark
				,
				duo.lower.mark
			);

		}

		static public R Center(this border.Co duo)
		{
			return
				nilnul.num.real.co_.divisible._DivX.Halve(
					nilnul.num.real.op_.binary_.Add.Singleton.op(
						duo.lower.mark
						,
						duo.upper.mark
					)
				);

		}

	}
}
