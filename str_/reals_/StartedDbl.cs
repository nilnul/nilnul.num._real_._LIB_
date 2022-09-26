using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.reals_
{
	public class StartedDbl :
		nilnul.objs_.Started4<double>
	{
		public StartedDbl(IEnumerable<double> seq) : base(seq)
		{
		}

		public StartedDbl(double head, IEnumerable<double> tail) : base(head, tail)
		{
		}
	}
}
