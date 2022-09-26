using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{
	public partial class SignAsInt
	{
		static public int Eval(double x) {
			if (x==0)
			{
				return 0;
				
			}
			return x > 0 ? 1 : -1;
		}
	}
}
