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
	public class Bordered
	: nilnul.obj.Box1<nilnul.num.real._border_.HasI>

	,
	nilnul.num.real.BeI
	{
		public Bordered(nilnul.num.real._border_.HasI val) : base(val)
		{
		}

		public bool be(RealI obj)
		{
			return boxed.contain(obj);
		}
	}

	public class BorderedDbl
: nilnul.obj.Box1<nilnul.num.real._border_.HasDblI>

,
nilnul.num.real.BeDblI
	{
		public BorderedDbl(_border_.HasDblI val) : base(val)
		{
		}


		public bool be(double obj)
		{
			return boxed.contain(obj);
		}
	}

}
