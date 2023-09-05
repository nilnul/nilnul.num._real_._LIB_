using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_.bisect
{
	static public class _RecurX
	{
		static public double _Repeat_timesAssumeNonneg(double x, int recurTimes) {

			while (recurTimes-->0)
			{
				x /= 2;
			}
			return x;
		}


	}
}
