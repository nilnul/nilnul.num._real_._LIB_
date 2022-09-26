using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_
{
	public class Spanned
		: nilnul.num.real.bound_.Closed
	{

		public Spanned(RealI border1, RealI border2) : base(border1, border2)
		{
			nilnul.obj_.bit.vow_._TrueX.Vow(border1.ToReal() < border2);

			//nilnul.bit.vow_._TrueX.Vow()
		}

		public Spanned(int v, Real real):this(
			new nilnul.num.real_.Quotient(v), real
		)
		{
			
		}

		public Spanned(Real real, int v):this(
			real,
			new nilnul.num.real_.Quotient(v) 
		)
		{
		}
	}
}
