using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positives_
{
	public class StartedDbl
		:
		nilnul.objs_.Started4<real_.PositiveDbl>
	{
		public StartedDbl(IEnumerable<PositiveDbl> seq) : base(seq)
		{
		}

		public StartedDbl(PositiveDbl head, IEnumerable<PositiveDbl> tail) : base(head, tail)
		{
		}
	}
}
