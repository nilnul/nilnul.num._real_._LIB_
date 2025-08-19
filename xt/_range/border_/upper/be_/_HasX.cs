using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow;
using nilnul.num.real.ext.border;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border_.upper.be_
{
	static public class _HasX
	{
		static public bool Has(this Border4dbl border, Ext4dbl x ) {
			return lower.be_._HasX.Has(

				-border,-x
			);
		}
		static public bool Has(this Border4dblI border, Ext4dbl x ) {
			return Has(
				border.ToImpl()
				,x
			);
		}

		static public bool Has(this Border4dblI border, Ext4dblI x ) {
			return lower.be_._HasX.Has(
				border, x.ToImpl()
			);
		}

		public  static bool Has(Border4dblI upper, Ee element)
		{
			return Has(upper, new Ext4dbl(element));
		}
	}
}
