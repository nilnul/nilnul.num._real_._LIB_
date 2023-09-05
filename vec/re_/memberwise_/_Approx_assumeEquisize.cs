using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.re_.memberwise_
{
	 public class _Approx_assumeEquisize
		:
		_Memberwise4dbl_assumeEquisize

	{
		public _Approx_assumeEquisize(real.re_.ApproximateDbl val) : base(val)
		{
		}

		public _Approx_assumeEquisize(double v):this(new real.re_.ApproximateDbl(v))
		{
		}
	}
}
