using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.real.interval
{
	public partial class ClosedDouble
		:nilnul.interval.ClosedInterval<double>
	{


		public ClosedDouble(double a,double b)
			:base(a,b)
		{
		}

		static public ClosedDouble ZeroToOne = new ClosedDouble(0, 1);
	

					

	}
}
