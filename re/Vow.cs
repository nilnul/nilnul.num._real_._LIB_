using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.re
{
	public class Vow4dbl
		: nilnul.obj.Box_ofIn<num.real.ReDblI>
		
		
	{
		public Vow4dbl(in ReDblI val) : base(val)
		{
		}

		public Vow4dbl(ReDblI x) : base(x)
		{
		}

		public void vow(double x, double y) {
			if (!this.boxed.re(x,y) )
			{
				throw new nilnul.obj_.xpn_.UnacceptableException( $"{boxed}( {x},{y}) doesnot hold;");
			}
		}
	}
}
