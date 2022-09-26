using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.reals_.started.op_.unary_.map_
{
	public class Invert : reals_.started.op_.unary_.MapDbl
	{
		public Invert(Func<double, double> val) : base(x=>1/x)
		{
		}


	}
}
