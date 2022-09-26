using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_
{
	public class Exp : real.stream_.slider.op_.binary_._multi.Of
	{
		public Exp(RealI x) : base(
			new real.stream_.slider_.quotient_.factorial.Inversed()
			,
			new real.stream_.slider_.geometric_.Std(x)
		)
		{
		}

		
	}
}
