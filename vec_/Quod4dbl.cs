using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_
{
	public class Quod4dbl
		:
		nilnul.obj.vec_.Quod<double>
	{
		public Quod4dbl((double, double, double, double) x) : base(x)
		{
		}

		public Quod4dbl(double item1, double item2, double item3, double item4) : base(item1, item2, item3, item4)
		{
		}
	}
}
