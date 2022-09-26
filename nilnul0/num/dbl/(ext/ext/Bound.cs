using nilnul.num.real.double_._ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext
{
	public class Bound:nilnul.order.Bound< real.double_._ext.ExtI>
	{

		public Bound(real.double_._ext.ExtI val, bool openFalseCloseTrue)
			:base(openFalseCloseTrue,val)
		{
			

		}

		public Bound(double val, bool openFalseCloseTrue)
			:this(new Literal(val) as real.double_._ext.ExtI, openFalseCloseTrue)
		{

		}

	}
}
