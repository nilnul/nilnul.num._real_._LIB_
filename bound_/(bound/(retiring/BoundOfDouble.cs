using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real._bound
{
	public class BoundOfDouble
		:nilnul.order.Bound<double>
	{
		public BoundOfDouble(double pinpoint,bool openFalseCloseTrue)
			:base(openFalseCloseTrue, pinpoint)
		{

		}
	}
}
