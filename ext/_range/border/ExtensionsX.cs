using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border
{
	static public class _ExtensionsX
	{
		static public Border4dbl ToImpl(this Border4dblI x) {
			return (x is Border4dbl y) ? y : new Border4dbl(x.openFalseCloseTrue,x.mark);
		}
	}
}
