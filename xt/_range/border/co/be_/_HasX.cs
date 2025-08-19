using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.be_
{
	static public class _HasX
	{
		static public bool Has(this (Border4dblI, Border4dblI) duo, Ext4dblI x ) {
			return border_.lower.be_._HasX.Has(duo.Item1, x)

				&&
				border_.upper.be_._HasX.Has(duo.Item2, x);
			
		}
	}
}
