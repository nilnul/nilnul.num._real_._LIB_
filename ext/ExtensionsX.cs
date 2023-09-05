using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext
{
	static public class _ExtensionsX
	{
		static public Ext4dbl ToImpl(this Ext4dblI x) {
			return (x is Ext4dbl y) ? y : new Ext4dbl(x.errable);
		}
	}
}
