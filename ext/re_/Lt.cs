using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.re_
{
	static public class _LtX
	{
		static public bool Lt(nilnul.num.real.ExtI x, nilnul.num.real.ExtI y)
		{
			if (x is ext_.inf_.Neg)
			{
				if (y is ext_.inf_.Neg)
				{
					return false;

				}
				return true;

			}
			if (x is ext_.Bare xBare)
			{
				if (y is ext_.inf_.Neg)
				{
					return false;
				}
				if (y is ext_.Bare yBare)
				{
					return nilnul.num.real.re_.Lt.Lazy.re(xBare.val, yBare.val);

				}
				return true;
			}
			if (x is ext_.inf_.Pos)
			{

				return false;

			}
			throw new UnexpectedTypeException();
		}
	}
}
