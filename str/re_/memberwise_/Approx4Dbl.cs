using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.re_.memberwise_
{
	public class Approx4Dbl
		: re_.Memberwise4dbl
		
	{
		public Approx4Dbl(real.re_.ApproximateDbl re ) : base(

				 re

		)
		{
		}

		public Approx4Dbl(double x):this(new real.re_.ApproximateDbl(x) )
		{

		}

		

	}
}
