using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num.real
{
	public class Span
		:
		border.duo.be.En<border.duo.be_.Spanned>
	{
		public Span(border.Duo duo):base(duo)
		{

		}

		public R diameter { get {
				return nilnul.num.real.border.duo._X.Diameter(this);
			} }

		public bool contains(R r) {

			return nilnul.num.real.border.duo._X.Contains(this, r);

		}





	}
}
