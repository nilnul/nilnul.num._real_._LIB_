using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_
{
	public class Tro4dbl
		:
		nilnul.obj.vec_.Tro<double>
	{
		public Tro4dbl((double, double, double) x) : base(x)
		{
		}

		public Tro4dbl(double item1, double item2, double item3) : base(item1, item2, item3)
		{
		}
	}
}
