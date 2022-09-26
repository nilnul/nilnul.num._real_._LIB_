using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_._ext._bound
{
	public class BoundInDouble :nilnul.order.Bound<ExtI>
	{

		public BoundInDouble(ExtI val, bool openFalseCloseTrue)
			:base(openFalseCloseTrue,val)
		{
			

		}

	}
}
