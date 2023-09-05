using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border_.lower.be_
{
	static public class _HasX
	{
		static public bool Has(this   Border4dblI border, Ext4dblI x ) {


			var markCompared = nilnul.num.real.ext.Comparer4dbl.Singleton.Compare(border.mark, x);

			if (markCompared == 0)
			{
				return border.openFalseCloseTrue;
			}

			return markCompared<0;


			
		}

		public static bool Has(this  Border4dblI border, Ee element)
		{
			return Has( border, new Ext4dbl(element) );
		}
	}
}
