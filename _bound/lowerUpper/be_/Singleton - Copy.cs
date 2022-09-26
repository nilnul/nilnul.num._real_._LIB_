using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lowerUpper.be_
{
	public class Single
		:
		nilnul.obj._bound.lowerUpper.be_.single_.EqDefault<
			double,
			_bound.LowerDbl
			,
			_bound.UpperDbl
			,
			nilnul.num.real.EqDbl
		>
		,
		lowerUpper.BeDblI
	{
		public bool be(LowerUpperDbl obj)
		{
			return base.be(obj);
		}
	}
}
