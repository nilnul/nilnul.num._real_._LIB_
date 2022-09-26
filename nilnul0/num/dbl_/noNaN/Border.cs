using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.double_.noNaN
{
	public class Border
		: nilnul.Border<b.NoNaN.Asserted>
	{
		public Border(b.NoNaN.Asserted obj, bool openFalseCloseTrue)
			:base(openFalseCloseTrue,obj)
		{

		}

		public Border(double mark, bool at)
			:this(
				new b.NoNaN.Asserted(mark),at	 
			 )
		{

		}
	}
}
