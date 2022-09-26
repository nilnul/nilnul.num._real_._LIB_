using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{
	/// <summary>
	/// in a bound. note bound is different from interval in that the border's mark is finite
	/// </summary>
	public class Bounded
	: nilnul.obj.Box1<nilnul.num.real.Bound1>

	,
	nilnul.num.real.BeI
	{
		public Bounded(Bound1 val) : base(val)
		{
		}

		public bool be(RealI obj)
		{
			return boxed.contain(obj);
		}
	}

	public class BoundedDbl
: nilnul.obj.Box1<nilnul.num.real.BoundDbl>

,
nilnul.num.real.BeDblI
	{
		public BoundedDbl(BoundDbl val) : base(val)
		{
		}

		public bool be(double obj)
		{
			return boxed.has(obj);
		}
	}

}
