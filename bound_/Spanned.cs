using nilnul.be.vow;
using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_
{
	public class Spanned
		: num.real.bound.be_.spanned.En
		,
		num.real.BoundI
		,
		_bound_.DiameterI
	{

		public Spanned(BoundI obj) : base(obj)
		{
		}

		public Spanned(num.real._bound.Lower lower, num.real._bound.Upper upper):this(
			new Bound1(lower,upper)
		)
		{

		}

		static public Spanned CreateClose(int v, RealI argSquared)
		{
			return new Spanned(
				Bound1.CreateClose(v,argSquared)
			);
		}

		public Lower lower => this.ee.lower;

		public Upper upper => this.ee.upper;

		public RealI diameter => BoundX.Diameter(this);

	


	}

}
