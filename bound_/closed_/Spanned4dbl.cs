using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_
{
	public class Spanned4dbl
		: nilnul.num.real.bound_.ClosedDbl
	{
		public Spanned4dbl(double border1, double border2) : base(border1, border2)
		{
			nilnul.obj_.bit.vow_._TrueX.Vow(border1 < border2);

			//nilnul.bit.vow_._TrueX.Vow()
		}

		public Spanned4dbl((double,double) closed) : this(closed.Item1,closed.Item2)
		{

			//nilnul.bit.vow_._TrueX.Vow()
		}
		public Spanned4dbl(bound_.ClosedDbl closed) : this(closed.avowed.lower.mark,closed.avowed.upper.mark)
		{

			//nilnul.bit.vow_._TrueX.Vow()
		}


		
	}
}
