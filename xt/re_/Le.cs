using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.re_
{
	static public class _LeX
	{
		static public bool Le(nilnul.num.real.ExtI x, nilnul.num.real.ExtI y) {
			if (x is ext_.inf_.Neg)
			{
				
					return true;
				
			}
			if (x is ext_.Bare xBare)
			{
				if (y is ext_.inf_.Neg )
				{
					return false;
				}
				if (y is ext_.Bare yBare)
				{
					return nilnul.num.real.re_.Le.Lazy.re(xBare.val, yBare.val);
					
				}
				return true;
			}
			if (x is ext_.inf_.Pos)
			{
				if (y is ext_.inf_.Pos)
				{
					return true;
				}
				return false;
			}
			throw new UnexpectedTypeException();
		}
	}
}
