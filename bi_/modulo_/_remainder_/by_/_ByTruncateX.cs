using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary_.modulo_._remainder_.by_
{
	/// <summary>
	/// x%y
	/// </summary>
	static public class _ByTruncateX
	{
		[Obsolete(nameof(IBySubtractFloor) + " is more readable;")]
		static public double _Remainder_1positive(double x, double y) {
			if (x>=0)
			{
				return x % y;
			}

			var t = (-x) % y;

			if (t==0)
			{
				return 0;
			}
			return t;
		}

	}


}
