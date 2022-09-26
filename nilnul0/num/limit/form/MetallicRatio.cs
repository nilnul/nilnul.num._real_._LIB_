using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.form
{
	public class MetallicRatio
	{
		static public RealI_posConverge2NonEmpty Create(BigInteger n)
		{

			return op.Divide_posConverge2interval.Half(
				op.Add_posConverge2bounded.Eval(n
				,
				new op.Sqrt.CallOfN(n * n + 4)

				)

				);

		}
	}
}
