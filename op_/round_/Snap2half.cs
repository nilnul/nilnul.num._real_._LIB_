using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.unary_.round_
{
	static public class _Snap2halfX
	{
		public static double Snap2half(double x,MidpointRounding midpointRounding= MidpointRounding.AwayFromZero)
		{
			return Math.Round(x * 2, midpointRounding) / 2;

		}
	}
}
