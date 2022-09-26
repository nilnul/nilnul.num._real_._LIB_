using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.intervals_
{
	public class Started 
		:
		nilnul.objs_.Started1<num.real.Interval,
			num.real.IntervalsI
		>
		,
		IntervalsI
	{
		public Started(Interval head, IntervalsI tail) : base(head, tail)
		{

		}
	}
}
