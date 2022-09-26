using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lowerUpper.be_
{
	public class Nonempty
		:
		nilnul.obj._bound.lowerUpper.be_.dwelt_.ComparerDefault_OnDenseObj
		<
			double, LowerDbl, UpperDbl, real.ComparerDbl
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
