using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._range.border.co
{
	static public class _MidX
	{
		static public double Mid(
			this 	num.real.range_.Closed4dbl x
		) {

			return num.real.of_.binary_.Mid.Singleton.op(x.lowerMark, x.upperMark).errable;
		}
		static public double Mid(
			this 	num.real.BoundDbl x
		) {
			return Mid(x.avowed);
		}

		public static double Mid(this LowerUpperDbl avowed)
		{
			return Mid(avowed.lower,avowed.upper);
		}

		private static double Mid(LowerDbl lower, UpperDbl upper)
		{
			return num.real.of_.binary_.Mid.Singleton._op_01finite(lower.mark,upper.mark);
		}
	}
}
